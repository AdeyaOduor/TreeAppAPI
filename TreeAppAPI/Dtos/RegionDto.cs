using System;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Dtos
{
    public class regionDto
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 region_code { get; set; }
        public string region_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
