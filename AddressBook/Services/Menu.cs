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
            Console.WriteLine("Välkommen till din AddressBook. Välj mellan 1-5");
            Console.WriteLine("1. Lägg till kontakt");
            Console.WriteLine("2. Se alla Kontakter ");
            Console.WriteLine("3. Kontaktinformation ");
            Console.WriteLine("4. Ta bort Kontakt");
            


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
                        Console.WriteLine("du valde 3");
                        break;
                    case 4:
                        Console.WriteLine("du valde 4");
                        break;
                    default:
                        Console.WriteLine("Ogiligt val. Försök igen");
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
            

    }

    private void ViewContacts()
    {
        Console.Clear();
        var users = _userList.GetUsers();

        foreach (var user in users)
        {
            Console.WriteLine($"Namn: {user.FirstName} {user.LastName}, Email: {user.Email}, Address: {user.Address},Telefon: {user.PhoneNumber}");
        }

        Console.WriteLine("Tryck på en knapp för att komma tillbaka till huvudmeny...");
        Console.ReadKey();
    }




}



