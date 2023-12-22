Console.WriteLine("--- Gestion des notes ---");
Console.WriteLine();
Console.WriteLine("Veuillez saisir 5 notes :");
Console.WriteLine();

int[] notes = new int[5];
for (int i = 0; i < notes.Length; i++)
{
    while (true)
    {
        Console.Write($"\t - Merci de saisir la note {i + 1} (sur /20) : ");
        if (int.TryParse(Console.ReadLine(), out int note) && note >= 0 && note <= 20)
        {
            notes[i] = note;
            break;
        }
        else
        {
            Console.WriteLine("Erreur: Vous devez entrer un chiffre entre 0 et 20.");
        }
    }
}

int meilleureNote = notes[0];
int moinsBonneNote = notes[0];
double sommeNotes = 0;

foreach (int note in notes)
{
    if (note > meilleureNote) meilleureNote = note;
    if (note < moinsBonneNote) moinsBonneNote = note;
    sommeNotes += note;
}

double moyenneNotes = sommeNotes / notes.Length;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"la meilleure note est {meilleureNote}/20");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"la moins bonne note est {moinsBonneNote}/20");
Console.ResetColor();

Console.WriteLine($"La moyenne des notes est {moyenneNotes:N2}/20");