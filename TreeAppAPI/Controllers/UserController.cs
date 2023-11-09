using AutoMapper;
using TreeAppAPIv1.Entities;
using TreeAppAPIv1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static TreeAppAPIv1.Dtos.DTOs;
using Microsoft.AspNetCore.Authorization;
using TreeAppAPIv1.Helpers;

namespace TreeAppAPIv1.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public UserController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        // GET api/User  (Get Users)
        [HttpGet]
        [BasicAuthentication]
        public async Task<IActionResult> GetUsers()
        {
            var ars_user = await uow.UserRepository.GetUsersAsync();
            var userDto = mapper.Map<IEnumerable<UserDto>>(ars_user);
            return Ok(userDto);
        }

        // POST api/user/login
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(User auser)
        {
            var mpass = encryptpass(auser.Password);

            var loginuser = await uow.UserRepository.Authenticate(auser.PNumber, mpass);

            if (loginuser == null)
            {
                return Unauthorized("Invalid username or password");
            }

            var loginRes = new UserLogin();
            loginRes.PNumber = loginuser.PNumber;
            loginRes.Surname = loginuser.Surname;
            loginRes.VerificationCode = CreateJWT(loginuser);
            return Ok(loginRes);
        }
        private string CreateJWT(User loginuser)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes("shhh.. this is my top secret"));

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, loginuser.Surname),
                new Claim(ClaimTypes.NameIdentifier, loginuser.PNumber.ToString())
            };

            var signingCredentials = new SigningCredentials(
                    key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        // POST through JSON
        [HttpPost("post")]
        [Authorize]
        public async Task<IActionResult> AddARS_User(User a_user)
        {
            uow.UserRepository.AddUser(a_user);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        //user/1
        [HttpGet("{UuId}")]

        public async Task<IActionResult> GeUserByUuIdAsync(string UuId)
        {
            var a_user = await uow.UserRepository.GetUserByUsernameAsync(UuId);
            return Ok(a_user);
        }

        // DELETE

        [HttpDelete("del/{id}")]
        [BasicAuthentication]
        public async Task<IActionResult> DeleteUser(string id)
        {
            uow.UserRepository.DeleteUser(id);
            await uow.SaveAsync();
            return Ok(id);
        }

        public string encryptpass(string password)
        {
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            string msg = Convert.ToBase64String(encode);
            return msg;
        }

        [HttpPost("SystemUser")]
        [AllowAnonymous]
        public async Task<IActionResult> AddSystemUser(APILogin a_user)
        {
            var myuser = new APILogin()
            {
                username = a_user.username,
                password = encryptpass(a_user.password),
                createdon = DateTime.Now,
                active = "0",
                Organization = a_user.Organization,
                UserRole = "Guest"
            };
            uow.UserRepository.AddSystemUser(myuser);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        public string Decrypt(string clearText)
        {
            string EncryptionKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }

}
