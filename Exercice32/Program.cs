var tab = new int[10];
var valeur = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Saisir la valeur {i + 1} : ");
    valeur = int.Parse(Console.ReadLine());
    tab[i] = valeur;
}

var tabulation = "\t"; 

foreach (int i in tab)
{
    Console.WriteLine($"{tabulation}{i}");
    tabulation += "\t";
}