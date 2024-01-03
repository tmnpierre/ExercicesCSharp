List<char> alphabet = new List<char>();

for (int i = 'A'; i <= 'Z'; i++)
    alphabet.Add((char)i);

Console.WriteLine("Affichage des valeurs du alphabetleau :");

string espaces = "";

for (int i = 0; i < alphabet.Count; i++)
{
    Console.WriteLine(espaces + alphabet[i]);
    espaces += "  ";
}