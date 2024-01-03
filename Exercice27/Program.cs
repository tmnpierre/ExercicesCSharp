Console.WriteLine("--- Les suites chaînées de nombres ---\n");
Console.Write("Merce de saisir un nombre : ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine("Les chaînes possibles sont :");

int midNumber = number / 2 + 1;
int debutChaine = 1;
while (debutChaine <= midNumber)
{
    int sum = 0;
    bool validChain = false;
    int finChaine = 0;

    int nombreAAdditionner = debutChaine;
    while (nombreAAdditionner <= midNumber)
    {
        sum += nombreAAdditionner;
        if (sum == number)
        {
            validChain = true;
            finChaine = nombreAAdditionner;
            break;
        }
        nombreAAdditionner++;
    }

    if (validChain)
    {
        Console.Write($"{number} = {debutChaine}");
        for (int j = debutChaine + 1; j <= finChaine; j++)
        {
            Console.Write("+" + j);
        }
        Console.WriteLine();
    }
    debutChaine++;
}
