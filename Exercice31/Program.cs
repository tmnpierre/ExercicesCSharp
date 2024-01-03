bool quitter = false;
float max = 0, min = 20, somme = 0, moyenne;
int nbNotes = 1;

while (!quitter)
{
    string choice;
    Console.WriteLine("--- Gestion des notes avec menu ---\n ");
    Console.Write("1----Saisir les notes" +
        "\n2----La meilleure note" +
        "\n3----La pire note" +
        "\n4----La moyenne des notes" +
        "\n0----Quitter" +
        "\n\nFaites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            int userInput;
            do
            {
                Console.Write("\t - Merci de saisir la note " + nbNotes + "(sur /20) :");
                while (!(int.TryParse(Console.ReadLine(), out userInput) && (userInput == 999 || (userInput >= 0 && userInput <= 20))))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                    Console.ResetColor();
                    Console.Write("\t - Merci de saisir la note " + nbNotes + "(sur /20) :");
                }

                if (userInput != 999)
                {
                    if (userInput > max)
                        max = userInput;
                    if (userInput < min)
                        min = userInput;
                    somme += userInput;
                    nbNotes++;
                }

            } while (userInput != 999);
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nla meilleure note est " + max + "/20");
            Console.ResetColor();
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("la moins bonne note est " + min + "/20");
            Console.ResetColor();
            break;
        case "4":
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("la moyenne des note est " + Math.Round((somme / ((float)nbNotes - 1)), 1) + "/20");
            Console.ResetColor();
            break;
        case "0":
            quitter = true; 
            break;
        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}