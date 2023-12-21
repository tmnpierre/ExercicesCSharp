Console.WriteLine("Listes des boisson disponible:");

Console.WriteLine("\t 1)Eau Plate");
Console.WriteLine("\t 2)Eau Gazeuse");
Console.WriteLine("\t 3)Coca-Cola");
Console.WriteLine("\t 4)Fanta");
Console.WriteLine("\t 5)Sprite");
Console.WriteLine("\t 6)Orangina");
Console.WriteLine("\t 7)7up");

Console.Write("Faite votre choix : ");
var choose =  Console.ReadLine();

switch (choose)
{
    case "1":
        Console.WriteLine("Votre Eau Plate est servi...");
    break;

    case "2":
        Console.WriteLine("Votre Eau Gazeuse est servi...");
    break;

    case "3":
        Console.WriteLine("Votre Coca-Cola est servi...");
    break;

    case "4":
        Console.WriteLine("Votre Fanta est servi...");
    break;

    case "5":
        Console.WriteLine("Votre Sprite est servi...");
    break;

    case "6":
        Console.WriteLine("Votre Orangina est servi...");
    break;

    case "7":
        Console.WriteLine("Votre 7Up est servi...");
    break;

    default:
        Console.WriteLine("Saisie Invalide");
    break;
}