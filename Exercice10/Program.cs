using System.ComponentModel.Design;

Console.Write("Entrer une lettre: ");
var input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    var voyelle = Char.ToUpper(input[0]);

    if (voyelle == 'A' || voyelle == 'E' || voyelle == 'I' || voyelle == 'O' || voyelle == 'U' || voyelle == 'Y')
        Console.WriteLine("Cette lettre est une voyelle");
    else
        Console.WriteLine("Cette lettre n'est pas une voyelle");
}
else
{
    Console.WriteLine("Aucune lettre n'a été entrée");
}
