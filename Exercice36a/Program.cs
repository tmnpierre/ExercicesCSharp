Console.WriteLine("***** Tableaux des notes *****");
Console.WriteLine();

int nombreDeNotes;
while (true)
{
    Console.Write("Combien de notes comportera le tableau : ");
    if (int.TryParse(Console.ReadLine(), out nombreDeNotes) && nombreDeNotes > 0)
    {
        break;
    }
    Console.WriteLine("Erreur de saisie, merci de saisir un nombre entier positif.");
}

double[] notes = new double[nombreDeNotes];

for (int i = 0; i < nombreDeNotes; i++)
{
    while (true)
    {
        Console.Write($"Merci de saisir la note {i + 1} : ");
        if (double.TryParse(Console.ReadLine(), out double note) && note >= 0 && note <= 20)
        {
            notes[i] = note;
            break;
        }
        Console.WriteLine("Erreur, merci de saisir un chiffre/nombre pour la note entre 0 et 20.");
    }
}

Console.WriteLine("\n--- Liste des notes ---");
for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine($"La note {i + 1} est de : {notes[i]}/20");
}

double maxNote = notes.Max();
double minNote = notes.Min();
double moyenne = notes.Average();

Console.WriteLine("\n--- La note max est : {0}/20", maxNote);
Console.WriteLine("--- La note min est : {0}/20", minNote);
Console.WriteLine("--- La moyenne est de : {0:0.00}/20", moyenne);

Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
Console.ReadLine();