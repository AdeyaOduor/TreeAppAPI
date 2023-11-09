using System;

namespace TreeAppAPIv1.Dtos
{
    public partial class APILoginDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public string active { get; set; }
        public string Organization { get; set; }
        public string UserRole { get; set; }
    }
}
