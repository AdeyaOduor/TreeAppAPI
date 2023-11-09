using System;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Dtos
{
    public class schoolDto
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 uic_code { get; set; }
        public string school_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
