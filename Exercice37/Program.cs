string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
                              "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

Console.WriteLine("Énumération du tableau avec un foreach :");

int index = 0;
foreach (string moisName in mois)
{
    string tabs = new String('\t', index++);
    Console.WriteLine(tabs + moisName);
}

Console.WriteLine("Appuyez sur Enter pour fermer le programme");
Console.ReadKey();