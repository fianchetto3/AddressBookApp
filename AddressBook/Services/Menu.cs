using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services;

internal class Menu
{
    public void MainMenu() { 
            
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till din AddressBook. Välj mellan 1-5");
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
                        Console.WriteLine("du valde 2");
                        break;
                    case 3:
                        Console.WriteLine("du valde 3");
                        break;
                    case 4:
                        Console.WriteLine("du valde 4");
                        break;
                    case 5:
                        Console.WriteLine("du valde 5");
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

        Console.Write("Ange Telefon Nummer: ");
        if (int.TryParse(Console.ReadLine(), out int phoneNumber))
        {
            user.PhoneNumber = phoneNumber;
        }
        else
        {
            Console.WriteLine("Ogiltigt telefonnummer");
        }
           
            

    }



}
