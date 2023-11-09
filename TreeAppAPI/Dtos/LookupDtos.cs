using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Dtos
{
    public class ST_CERTIFICATEDto
    {
        public int Certificate_Id { get; set; }
        public string Certificate_Details { get; set; }
        public int OrderID { get; set; }
    }

    public class ST_EDUCATION_LEVELDto
    {
        public int Education_level_Id { get; set; }
        public string Level_of_Education { get; set; }
        public int OrderID { get; set; }
    }

    public class ST_QUALIFICATIONDto
    {
        public string Qualification { get; set; }
        public string QualificationName { get; set; }
        public string Groupid { get; set; }
    }

    public class ST_QUALLEVELDto
    {
        public string Qualification { get; set; }
        public string QualificationName { get; set; }
        public int OrderID { get; set; }
    }
}
