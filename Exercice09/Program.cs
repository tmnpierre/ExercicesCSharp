Console.WriteLine("--- Calcul des intérêts --- \n");
Console.Write("Entrez Capital de départ (en Euros): ");
var a = double.Parse(Console.ReadLine());
Console.Write("Entré le taux d'intérêt (en %): ");
var b = double.Parse(Console.ReadLine());
Console.Write("Entré la durée de l'épargne (en années): ");
var c = double.Parse(Console.ReadLine());

Console.WriteLine();
double d = (a * (b / 100) * c);
Console.WriteLine($"Le montant des intérêt sera de {d} euros en {c} années");
double e = a + d;
Console.WriteLine($"Le Capital final est de {e} euros");