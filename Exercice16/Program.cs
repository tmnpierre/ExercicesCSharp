Console.WriteLine("Quelle sera le montant de mes impôts ?");

Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
double netTaxableAmount = double.Parse(Console.ReadLine());

Console.Write("Entrez le nombre d'adulte(s) du foyer: ");
int numberOfAdults = int.Parse(Console.ReadLine());

Console.Write("Entrez le nombre d'enfant(s) du foyer: ");
int numberOfChildren = int.Parse(Console.ReadLine());

double parts = numberOfAdults + Math.Max(0, numberOfChildren - 1) + Math.Min(numberOfChildren, 1) * 0.5;

double taxableAmountPerPart = netTaxableAmount / parts;
double tax = 0;

double totalTax = Math.Round(tax * parts);

Console.WriteLine($"Vous allez payer {totalTax} Euros");