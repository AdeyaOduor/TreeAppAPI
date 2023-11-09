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
//         public string CountyCode { get; set; }
//         public string CountyName { get; set; }
//     }
// }

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Entities
{
    public class county
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 county_code { get; set; }
        public string county_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
