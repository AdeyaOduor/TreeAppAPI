using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Entities
{
    public class User
    {
        [Key]
        public string PNumber { get; set; }
        public string Salutation { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Desig_Code { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public bool ActiveUsers { get; set; }
        public string IDNo { get; set; }
        public string Responsibilities { get; set; }
        public string Email { get; set; }
    }
    public class UserLogin
    {
        [Key]
        public string PNumber { get; set; }
        public string Salutation { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public bool ActiveUsers { get; set; }
        public string IDNo { get; set; }
        public string Responsibilities { get; set; }
        public string Email { get; set; }
        public string VerificationCode { get; set; }
    }
}
