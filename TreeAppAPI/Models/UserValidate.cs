using TreeAppAPIv1.Data;
using TreeAppAPIv1.Entities;
using System;
using System.Linq;

namespace TreeAppAPIv1.Models
{
    public class UserValidate
    {
        //This method is used to check the user credentials
        public static bool Login(string username, string password)
        {
            using (DataContext entity = new DataContext())
            {
                return entity.APILogins.Any(x => x.username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.password == password && x.active == "1");
            }
        }

        //This method is used to return the User Details
        public static APILogin GetUserDetails(string username, string password)
        {
            DataContext entity = new DataContext();

            return entity.APILogins.FirstOrDefault(user =>
                user.username.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.password == password);
        }
    }
}
