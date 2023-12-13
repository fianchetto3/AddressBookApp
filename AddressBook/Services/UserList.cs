using AddressBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal class UserList
    {
        private  List<User> _users = [];
        private readonly FileService _fileService = new FileService(@"C:\Projects\content.json");

        public void AddUserToUserList(User user)
        {
            try
            {
                if (!_users.Any(x => x.Email == user.Email))
                {
                    _users.Add(user);
                    _fileService.SaveContentToFile(JsonConvert.SerializeObject(_users));
                }

            }
            catch (Exception ex) { Debug.Write(ex.Message); }


        }

        public IEnumerable<User> GetUsersFromJsonList()
        {

            try
            {
                var content = _fileService.GetContentFromFile();
                if (!string.IsNullOrEmpty(content))
                {
                   _users = JsonConvert.DeserializeObject<List<User>>(content)!;
                }
                


            }
            catch (Exception ex) { Debug.Write(ex.Message); }
            return _users;

        }


        public User GetUserFromUserList(string email)
        {
            var user = _users.FirstOrDefault(x => x.Email == email);
            return user ??= null!;
        }

        public void RemoveUserFromUserList (string email) 
        {
            try
            {
                var userToRemove = _users.FirstOrDefault(x => x.Email == email);        ///    matchar email med existerande användare, om user inte är null tas den bort efter begäran.
                if (userToRemove != null)                                   
                {
                    _users.Remove(userToRemove);
                    _fileService.SaveContentToFile(JsonConvert.SerializeObject(_users));   /// Uppdaterar json filen, tar bort användaren.
                }
            } catch (Exception ex) { Debug.Write(ex.Message); }

        }


    }
}
