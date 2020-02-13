using System;
using System.Collections.Generic;
using System.Linq;
using UserEntity;
using System.Text;
using System.Threading.Tasks;

namespace UserRepositary
{
    public class LibraryRepositary
    {
        public static List<User> user = new List<User>();
        static LibraryRepositary()
        {
            user.Add(new User { name = "gowri", userName = "shankar" });
        }
        public static IEnumerable<User> GetUser()
        {
            return user;
        }


    }
}
