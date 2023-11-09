// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace TreeAppAPIv1.Entities
// {
//     public class ST_COUNTY
//     {
//         [Key]
//         public string SchoolCode { get; set; }
//         public string schoolName { get; set; }
//     }
// }

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Entities
{
    public class school
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 uic_code { get; set; }
        public string schol_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
