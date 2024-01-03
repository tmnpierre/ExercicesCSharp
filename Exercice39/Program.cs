Console.WriteLine("***** Le Grand tirage au sort ! *****");
Console.WriteLine();

bool continuer = true;
Random random = new Random();

List<string> prenoms = new List<string>
        {
            "Emma",
            "Lucas",
            "Chloé",
            "Hugo",
            "Alice",
            "Louis",
            "Léa",
            "Gabriel",
            "Zoé",
            "Ethan",
            "Inès",
            "Raphaël",
            "Sarah",
            "Arthur",
            "Julia",
            "Jules",
            "Louise",
            "Adam",
            "Lina",
            "Nathan"
        };
List<string> prenomsTired = new List<string> { };

while (continuer)
{
    Console.Clear();
    Console.WriteLine("1--- Effectuer un tirage\n2--- Voir la liste des personnes déjà tirées\n3--- Voir la liste des personnes restantes\n0--- Quitter");
    Console.Write("\nSaisir votre choix : ");
    var saisie = Console.ReadLine();
    
    switch (saisie)
    {
        case "0":
            continuer = false; 
            break;
        case "1":
            Console.Clear();
            if (prenoms.Count > 0)
            {
                int index = random.Next(prenoms.Count);
                string selectedName = prenoms[index];
                prenomsTired.Add(selectedName);
                prenoms.RemoveAt(index);
                Console.WriteLine($"Prenom tiré au sort: {selectedName}");
                Console.Write("Appuyer sur une touche pour revenir au menu : ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Tout le monde est mort.");
                Console.Write("Appuyer sur une touche pour revenir au menu : ");
                Console.ReadKey();
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Prénoms déjà tirés :");
            foreach (string name in prenomsTired)
            {
                Console.WriteLine(name);
            }
            Console.Write("Appuyer sur une touche pour revenir au menu : ");
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Liste des personnes restantes :");
            foreach (string s in prenoms)
            {
                Console.WriteLine(s);
            }
            Console.Write("Appuyer sur une touche pour revenir au menu : ");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Choix non valide. Veuillez faire un choix valide");
            break;
    }
}