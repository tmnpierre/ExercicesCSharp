Console.WriteLine("--- Où est passé mon numéro ? ---");
Console.WriteLine("Affectation des valeurs...");

Random random = new Random();
int[] numbers = new int[10];
var tabulation = "\t";
var tabulation2 = "\t";

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 51);
}

Console.WriteLine("\nAffichage avant triage :");
foreach (int number in numbers)
{
    Console.WriteLine($"{tabulation}{number}");
    tabulation += "\t";
}

int firstNumber = numbers[0];

Array.Sort(numbers);

Console.WriteLine("\nAprès :");
foreach (int number in numbers)
{
    Console.WriteLine($"{tabulation2}{number}");
    tabulation2 += "\t";
}

int newPosition = Array.IndexOf(numbers, firstNumber) + 1;

Console.WriteLine($"\nLe nombre {firstNumber} se trouvait en 1ere position");
Console.WriteLine($"Il se retrouve à la position {newPosition} après triage.");