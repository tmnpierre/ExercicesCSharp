ConsoleColor[] colors = new ConsoleColor[] {
            ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow,
            ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan,
            ConsoleColor.Gray, ConsoleColor.DarkRed, ConsoleColor.DarkGreen,
            ConsoleColor.DarkYellow, ConsoleColor.DarkBlue, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkCyan, ConsoleColor.White,
        };

Console.Write("Entrez le nombre de table de multiplication que vous souhaitez voir : ");
int tableSize;
while (!int.TryParse(Console.ReadLine(), out tableSize))
{
    Console.WriteLine("Veuillez entrer un nombre valide.");
}


for (int i = 0; i <= tableSize; i++)
{
    if (i == 0)
    {
        Console.Write("   |");
    }
    else
    {
        Console.ForegroundColor = colors[(i - 1) % colors.Length];
        Console.Write($"{i,3} |");
        Console.ResetColor();
    }
}
Console.WriteLine();

Console.WriteLine(new String('-', tableSize * 4 + 4));

for (int i = 1; i <= tableSize; i++)
{

    Console.ForegroundColor = colors[(i - 1) % colors.Length];
    Console.Write($"{i,3} |");
    Console.ResetColor();

    for (int j = 1; j <= tableSize; j++)
    {

        Console.ForegroundColor = colors[(i + j - 2) % colors.Length];


        Console.Write($"{i * j,3} |");
        Console.ResetColor();
    }
    Console.WriteLine();


    if (i % 10 == 0 && i != tableSize)
    {
        Console.WriteLine(new String('+', tableSize * 4 + 4));
    }
    else if (i < tableSize)
    {
        Console.WriteLine(new String('-', tableSize * 4 + 4));
    }
}


if (tableSize % 10 == 0)
{
    Console.WriteLine(new String('+', tableSize * 4 + 4));
}
else
{
    Console.WriteLine(new String('-', tableSize * 4 + 4));
}