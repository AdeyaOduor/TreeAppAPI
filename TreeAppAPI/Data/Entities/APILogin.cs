using System;
using System.ComponentModel.DataAnnotations;

namespace TreeAppAPIv1.Entities
{
    public partial class APILogin
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public string active { get; set; }
        public string Organization { get; set; }
        public string UserRole { get; set; }
    }
    public partial class APILogin2
    {
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public string active { get; set; }
        public string Organization { get; set; }
        public string UserRole { get; set; }
    }
}
