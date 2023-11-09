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
//         public string SubCountyCode { get; set; }
//         public string subCountyName { get; set; }
//     }
// }

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Entities
{
    public class subcounty
    {
        [Key]
        public Int64 id { get; set; }
        public Int64 subcounty_code { get; set; }
        public string subcounty_name { get; set; }
        public Int64 user_identifier_id { get; set; }
    }
}
