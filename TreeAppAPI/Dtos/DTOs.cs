using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Dtos
{
    public class DTOs
    {
        public class ST_REGIONDto
        {
            public string RegionCode { get; set; }
            public string RegionName { get; set; }
        }
        public class ST_REGIONUpdDto
        {
            [Required]
            public string RegionName { get; set; }
        }

         public class ST_COUNTYDto
        {
            public string CountyCode { get; set; }
            public string CountyName { get; set; }
        }
        public class ST_COUNTYUpdDto
        {
            [Required]
            public string CountyName { get; set; }
        }

         public class ST_SUBCOUNTYDto
        {
            public string SubCountyCode { get; set; }
            public string subCountyName { get; set; }
        }
        public class ST_SUBCOUNTYUpdDto
        {
            [Required]
            public string SubCountyName { get; set; }
        }

         public class ST_SCHOOLDto
        {
            // public string SchoolCode { get; set; }
            public string uic_code { get; set; }
            public string SchoolName { get; set; }
        }
        public class ST_SCHOOLUpdDto
        {
            [Required]
            public string SchoolName { get; set; }
        }

        public class UserDto
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
    }
}
