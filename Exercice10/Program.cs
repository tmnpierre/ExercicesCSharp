Console.Write("Entrer une lettre: ");
var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input) && input.Length == 1)
{
    var voyelle = Char.ToUpper(input[0]);
    string vowels = "AEIOUY";

    if (vowels.Contains(voyelle))
        Console.WriteLine("Cette lettre est une voyelle");
    else
        Console.WriteLine("Cette lettre n'est pas une voyelle");
}
else if (input.Length > 1)
{
    Console.WriteLine("Veuillez entrer une seule lettre");
}
else
{
    Console.WriteLine("Aucune lettre n'a été entrée");
}