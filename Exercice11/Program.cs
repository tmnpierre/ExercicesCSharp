Console.Write("Entrez un chiffre/nombre entier: ");
string inputA = Console.ReadLine();
var a = int.Parse(inputA);

Console.Write("Entrez un chiffre/nombre entier: ");
string inputB = Console.ReadLine();
var b = int.Parse(inputB);

string c = a.ToString().Length == 1 ? "Le chiffre" : "Le nombre";

if (b != 0 && a % b == 0)
{
    Console.WriteLine($"{c} est divisible par {b}");
}
else if (b == 0)
{
    Console.WriteLine("Division par zéro n'est pas possible");
}
else
{
    Console.WriteLine($"{c} n'est pas divisible par {b}");
}