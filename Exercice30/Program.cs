Console.WriteLine("Quelle est l'instruction qui permet de sortir d'un boucle en C# ?");
Console.WriteLine("\t a: quit");
Console.WriteLine("\t b: continue");
Console.WriteLine("\t c: break");
Console.WriteLine("\t d: la réponse d");
Console.WriteLine();

Console.Write("Entrez votre réponse : ");
var reponse = Console.ReadLine();

while (reponse != "c")
{
    Console.WriteLine("Réponse incorrecte");
    Console.WriteLine("Voulez vous réessayer ? oui/non");
    var reponse2 = Console.ReadLine();

    if (reponse2 == "oui")
    {
        Console.Write("Entrez votre nouvelle réponse : ");
        reponse = Console.ReadLine();
    }
    else if (reponse2 == "non")
    {
        Console.WriteLine("Vous pouvez quitter");
        return;
    }
    else
    {
        Console.Write("Réponse invalide!");
    }
}

Console.WriteLine("Bonne réponse");