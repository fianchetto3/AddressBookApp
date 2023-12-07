using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models;

public class User
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;
    public int? PhoneNumber { get; set; } 
    public string Address { get; set; } = null!; 

    public User() { 
    
    }

    
}
