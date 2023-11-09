using System;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Dtos
{
    public class countyDto
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 county_code { get; set; }
        public string county_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
