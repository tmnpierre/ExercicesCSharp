Console.Write("Entrez le nombre de notes /20 : ");
int nombreDeNotes = int.Parse(Console.ReadLine());
double[] notes = new double[nombreDeNotes];

for (int i = 0; i < nombreDeNotes; i++)
{
    Console.Write($"Entrez la note {i + 1} /20 : ");
    notes[i] = double.Parse(Console.ReadLine());
}

Console.Write("\nToutes les notes : ");
foreach (double note in notes)
{
    Console.Write($"{note}/20");
}

double maxNote = notes.Max();
double minNote = notes.Min();
double moyenne = notes.Average();

Console.WriteLine($"\nNote Max: {maxNote}");
Console.WriteLine($"Note Min: {minNote}");
Console.WriteLine($"Moyenne: {moyenne}");
