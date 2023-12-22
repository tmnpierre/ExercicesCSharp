Console.Write("Combien de table ? : ");
int size;
while (!int.TryParse(Console.ReadLine(), out size))
{
    Console.WriteLine("S'il vous plaît, entrez un nombre entier valide pour la taille de la table de multiplication.");
}

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

for (int row = 1; row <= size; row++)
{
    for (int column = 1; column <= size; column++)
    {
        int product = row * column;
        if (Math.Sqrt(product) % 1 == 0)
        {
            Console.ForegroundColor = colors[(int)Math.Sqrt(product) % colors.Length];
        }

        Console.Write($"{product}\t");
        Console.ResetColor();
    }
    Console.WriteLine();
}