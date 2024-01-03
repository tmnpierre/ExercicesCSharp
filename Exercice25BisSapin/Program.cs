List<ConsoleColor> ballColors = new List<ConsoleColor>()
{
    ConsoleColor.Red,
    ConsoleColor.Magenta,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.Yellow
};

Random random = new Random();

Console.WriteLine("Saisir la hauteur du sapin : ");
int hauteur = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Saisir la hauteur du tronc : ");
int tronc = Convert.ToInt32(Console.ReadLine());


while (true) 
{
    for (int ligne = 1; ligne <= hauteur; ligne++) 
    {
        for (int espaces = 1; espaces <= hauteur - ligne; espaces++) 
            Console.Write(" ");

        if (ligne == 1) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("A");
        }
        else
            for (int etoiles = 1; etoiles <= 2 * ligne - 1; etoiles++) 
            {
                string symb;
                if (random.NextDouble() > 0.33)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    symb = "*";
                }
                else
                {
                    Console.ForegroundColor = ballColors[random.Next(ballColors.Count)];
                    symb = "o";
                }
                Console.Write(symb);
            }
        Console.WriteLine();
    }

    Console.ForegroundColor = ConsoleColor.DarkRed;
    string espacesTronc = string.Concat(Enumerable.Repeat(" ", hauteur - 2));
    for (int i = 0; i < tronc; i++)
    {
        Console.WriteLine(espacesTronc + "| |");
    }

    Thread.Sleep(500);
    Console.Clear();
}
Console.ForegroundColor = ConsoleColor.Gray;