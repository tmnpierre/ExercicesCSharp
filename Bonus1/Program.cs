Console.Write("Entrez le nombre de table de multiplication que vous souhaitez voir : ");
int tableSize;
while (!int.TryParse(Console.ReadLine(), out tableSize))
{
    Console.WriteLine("Veuillez entrer un nombre valide.");
}

Console.Write(" ".PadRight(3));
for (int i = 1; i <= tableSize; i++)
{
    Console.Write("|" + i.ToString().PadLeft(3));
}
Console.WriteLine("|");
Console.WriteLine(new String('=', tableSize * 4 + 4));

for (int i = 1; i <= tableSize; i++)
{
    Console.Write(i.ToString().PadRight(3) + "|");
    for (int j = 1; j <= tableSize; j++)
    {
        Console.Write((i * j).ToString().PadLeft(3) + "|");
    }
    Console.WriteLine();
    Console.WriteLine(new String('-', tableSize * 4 + 4));
}
