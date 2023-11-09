using System;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Dtos
{
    public class subcountyDto
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 subcounty_code { get; set; }
        public string subcounty_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
