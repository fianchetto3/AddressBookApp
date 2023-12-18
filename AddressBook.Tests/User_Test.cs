using AddressBook.Models;
using AddressBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Tests;

public class User_Test
{
    [Fact]
     public void AddUserToList_Should_AddOneUserToUserList_ThenReturnTrue()
    {
        // Arrange
        var userList = new UserList();

        var userToAdd = new User
        {
            FirstName = "Sven",
            LastName = "Svensson",
            Email = "Email@domain.com",
            PhoneNumber = "1234567890",
            Address = "Storgatan 10"
        };
        bool addUserResult;
        // Act
        try
        {
            userList.AddUserToUserList(userToAdd);
            addUserResult = true;
        }
        catch
        {
            addUserResult= false;
        }


        // Assert
        Assert.True(addUserResult);

    }
}
