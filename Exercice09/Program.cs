Console.WriteLine("--- Calcul des intérêts composés --- \n");

Console.Write("Entrez le Capital de départ (en Euros): ");
var principal = double.Parse(Console.ReadLine());

Console.Write("Entrez le taux d'intérêt annuel (en %): ");
var annualInterestRate = double.Parse(Console.ReadLine()) / 100; // Convertir le pourcentage en décimal

Console.Write("Entrez la durée de l'épargne (en années): ");
var years = int.Parse(Console.ReadLine());

double amount = principal * Math.Pow(1 + annualInterestRate, years);
double interest = amount - principal;

Console.WriteLine($"\nLe montant des intérêts sera de {interest:F2} euros en {years} années");
Console.WriteLine($"Le Capital final est de {amount:F2} euros");
