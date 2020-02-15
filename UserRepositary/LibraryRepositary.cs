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
            user.Add(new User { name = "gowri", userName = "shankar",email="gowrishankar17022000@gmail.com" });
        }
        public static IEnumerable<User> GetUser()
        {
            return user;
        }
        public void AddUser(User addUser)
        {
            user.Add(addUser);
        }
        public User GetUserByUserName(string userName)
        {
          return  user.Find(username => username.userName == userName);
        }
        public void UpdateUser(User user)
        {
            User userentity = GetUserByUserName(user.userName);
            userentity.userName = user.userName;
            userentity.name = user.name;
            userentity.email = user.email;
        }
        public void DeleteUser(string userName)
        {
            User userEntity = GetUserByUserName(userName);
                user.Remove(userEntity);
        }

    }
}
