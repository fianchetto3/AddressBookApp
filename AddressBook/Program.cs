// See https://aka.ms/new-console-template for more information
Console.WriteLine("Välkommen till din AddressBook. Välj mellan 1-5");
Console.WriteLine("1. Lägg till kontakt");
Console.WriteLine("2. Se alla Kontakter ");
Console.WriteLine("3. Kontaktinformation ");
Console.WriteLine("4. Ta bort Kontakt");
Console.WriteLine("5. Avlsuta");


int choice;

if (int.TryParse(Console.ReadLine(), out choice))
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("du valde 1");
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
         default: Console.WriteLine("Ogiligt val. Försök igen");
            break;

            

    }
}
    
