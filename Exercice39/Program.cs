Console.WriteLine("***** Le Grand Tirage au Sort ! *****");
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
List<string> prenomsTires = new List<string>();

while (continuer)
{
    Console.Clear();
    Console.WriteLine("1--- Effectuer un tirage\n2--- Voir la liste des personnes déjà tirées\n3--- Voir la liste des personnes restantes\n0--- Quitter");
    Console.Write("\nSaisissez votre choix : ");
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
                string prenomSelectionne = prenoms[index];
                prenomsTires.Add(prenomSelectionne);
                prenoms.RemoveAt(index);
                Console.WriteLine($"Prénom tiré au sort : {prenomSelectionne}");
                Console.Write("Appuyez sur une touche pour revenir au menu : ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Tous les prénoms ont été tirés.");
                Console.Write("Appuyez sur une touche pour revenir au menu : ");
                Console.ReadKey();
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Prénoms déjà tirés :");
            foreach (string nom in prenomsTires)
            {
                Console.WriteLine(nom);
            }
            Console.Write("Appuyez sur une touche pour revenir au menu : ");
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Liste des personnes restantes :");
            foreach (string nom in prenoms)
            {
                Console.WriteLine(nom);
            }
            Console.Write("Appuyez sur une touche pour revenir au menu : ");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Choix non valide. Veuillez faire un choix valide.");
            break;
    }
}
