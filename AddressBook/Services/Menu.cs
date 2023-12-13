using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services;

internal class Menu
{
    private readonly UserList _userList = new UserList();


    public void MainMenu() { 
            
        while (true)
        {
            Console.Clear();
            Console.WriteLine("## Välkommen till din AddressBook. Välj mellan 1-5 ##");
            Console.WriteLine("1. Lägg till kontakt");
            Console.WriteLine("2. Se alla Kontakter ");
            Console.WriteLine("3. Kontaktinformation ");
            Console.WriteLine("4. Ta bort Kontakt");
            Console.WriteLine("5. Avsluta");

         

            int choice;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddMenu();
                        break;
                    case 2:
                        ViewContacts();
                        break;
                    case 3:
                        ViewContactInformation();
                        break;
                    case 4:
                        RemoveUser();
                        break;
                        case 5:
                        Console.WriteLine("Tack för att du använder AdressBook. Programmet Avslutas.");
                            Environment.Exit(5);
                        break;
                    default:
                        Console.WriteLine("Ogiligt val. Försök igen");
                        Console.ReadKey();
                        break;
                }
            }


        }

    }

    private void AddMenu()
    {
        var user = new User();

        Console.Clear();
        Console.Write("Ange Förnamn: ");
        user.FirstName = Console.ReadLine()!;

        Console.Write("Ange Efternamn: ");
        user.LastName = Console.ReadLine()!;

        Console.Write("Ange Email: ");
        user.Email = Console.ReadLine()!;

        Console.Write("Ange Address: ");
        user.Address = Console.ReadLine()!;

        Console.Write("Ange Telefon Nummer: ");
        user.PhoneNumber = Console.ReadLine()!;
        _userList.AddUserToUserList(user);

        Console.WriteLine("Kontakt Tillagd!, Tryck på en knapp för att komma tillbaka till huvudmeny...");
        Console.ReadKey();

    }

    private void ViewContacts()
    {
        Console.Clear();
        var users = _userList.GetUsersFromJsonList();

        foreach (var user in users)
        {
            Console.WriteLine($"Namn: ### {user.FirstName} {user.LastName} ### ");
            Console.WriteLine($"Email ### {user.Email} ### ");
            Console.WriteLine();
           
        }

        Console.WriteLine("Tryck på en knapp för att komma tillbaka till huvudmeny...");
        Console.ReadKey();
    }
    
    private void ViewContactInformation()
    {
        Console.Clear();

        var user = new User();
        var users = _userList.GetUsersFromJsonList();
        
        Console.Write("Ange användarens email för att visa information: ");
        string userEmail = Console.ReadLine();

        Console.Clear();

        var selectedUser = _userList.GetUserFromUserList(userEmail);                                         /// selectedUser hämtar ut användarens email från UserList. userEmail kan vara null men checkas i If satsen.
        if (selectedUser != null)
        {
            Console.WriteLine($"Namn: {selectedUser.FirstName} {selectedUser.LastName}");                   /// från GetUserFromUserList klassen hämtas korrekt info om användaren baserat på Epost.
            Console.WriteLine($"Email: {selectedUser.Email}");
            Console.WriteLine($"Address: {selectedUser.Address}");
            Console.WriteLine($"Telefon: {selectedUser.PhoneNumber}");
        }
        else
        {
            Console.WriteLine("Användaren hittades inte.");

        }
        Console.WriteLine("Tryck på en knapp för att komma tillbaka till huvudmeny...");
        Console.ReadKey();
    }

    private void RemoveUser() 
    {

        Console.Clear();
        Console.Write("ange email för användaren du vill ta bort: ");                       
        var user = new User();
        string userEmail = Console.ReadLine();                                          

        Console.Clear();

        var userToRemove = _userList.GetUserFromUserList(userEmail);                                    ///  Ungefär samma funktionalitet som ViewContactInfo()
        if (userToRemove != null)                                                                      ///  Vi checkar ifall de finns en användare med den email som skrivs in
        {                                                                                              ///  Ifall de finns så kallar vi på RemoveUserFromList metoden. 
            _userList.RemoveUserFromUserList(userEmail);                                                
            Console.WriteLine($" Användaren har tagits bort...");
        }
        else 
        {
            Console.WriteLine($"användaren med email {userEmail} kunde inte hittas. ");
        }
        Console.WriteLine("Tryck på en knapp för att komma tillbaka till huvudmeny...");
        Console.ReadKey();
    }


}



