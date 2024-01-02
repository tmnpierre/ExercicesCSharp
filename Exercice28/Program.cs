Random aleatoire = new Random();
int test = aleatoire.Next(1, 51);

Console.Write("Entrez un nombre entre 1 et 50 : ");
int reponse = int.Parse(Console.ReadLine());
Console.WriteLine();
int nbCoup = 1; 

while (reponse != test)
{
    if (reponse > test)
    {
        Console.Write("Plus petit, entrez un nouveau nombre : ");
        reponse = int.Parse(Console.ReadLine());
        Console.WriteLine();
        nbCoup++;
    }
    else if (reponse < test)
    {
        Console.Write("Plus grand, entrez un nouveau nombre : ");
        reponse = int.Parse(Console.ReadLine());
        Console.WriteLine();
        nbCoup++;
    }
}

Console.WriteLine("Bonne réponse");
Console.WriteLine($"Vous avez trouver en {nbCoup} coups");