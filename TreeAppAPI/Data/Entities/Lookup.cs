using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Entities
{
    public class Lookup
    {
    }
    public class ST_CERTIFICATE
    {
        [Key]
        public int Certificate_Id { get; set; }
        public string Certificate_Details { get; set; }
        public int OrderID { get; set; }
    }

    public class ST_EDUCATION_LEVEL
    {
        [Key]
        public int Education_level_Id { get; set; }
        public string Level_of_Education { get; set; }
        public int OrderID { get; set; }
    }

    public class ST_QUALIFICATION
    {
        [Key]
        public string Qualification { get; set; }
        public string QualificationName { get; set; }
        public string Groupid { get; set; }
    }

    public class ST_QUALLEVEL
    {
        [Key]
        public string Qualification { get; set; }
        public string QualificationName { get; set; }
        public int OrderID { get; set; }
    }

}
