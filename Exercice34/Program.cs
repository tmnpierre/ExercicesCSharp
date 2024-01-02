Console.Write("Saisir la taille du tableau : ");
var saisie = int.Parse(Console.ReadLine());

var tab = new int[saisie];
Random aleatoire = new Random();

for (int i = 0; i < saisie; i++)
{
    tab[i] = aleatoire.Next(1, 51);
}

var tabulation = "\t";

foreach (int i in tab)
{
    string paire;

    if (i % 2 == 0)
    {
        paire = $"Le nombre {i} est pair";
    }
    else
    {
        paire = $"Le nombre {i} est impair";
    }

    Console.WriteLine($"{tabulation}{paire}");
    tabulation += "\t";
}
