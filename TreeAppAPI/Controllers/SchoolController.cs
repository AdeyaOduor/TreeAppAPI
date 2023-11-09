using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeAppAPIv1.Dtos;
using TreeAppAPIv1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public SchoolController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        // GET api/School
        [HttpGet]
        //[Route("All")]
        public async Task<IActionResult> GetSchool()
        {
            var school = await uow.SchoolRepository.GetSchoolAsync();
            var custDto = mapper.Map<IEnumerable<schoolDto>>(school);
            return Ok(custDto);
        }

        //School/1
        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            var aschool = await uow.schoolRepository.GetSchoolByNoAsync(id);
            return Ok(aschool);
        }

    }
}
