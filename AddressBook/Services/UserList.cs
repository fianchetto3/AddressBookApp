using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal class UserList
    {
        private readonly List<User> _users = [];

        public void AddUserToUserList(User user)
        {
            if (!_users.Any(x => x.Email == user.Email))
            {
                _users.Add(user);
            }
            
        }
        public User GetUserFromUserList(string email)
        {
            var user = _users.FirstOrDefault(x => x.Email == email);
            return user ??= null!;
        }

        public void RemoveUserFromUserList (User user) 
        { 
         _users.Remove(user);
        }

        public List<User> GetUsers() 
        {  return _users; }
    }
}
