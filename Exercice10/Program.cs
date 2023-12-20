using System.ComponentModel.Design;

Console.Write("Entrer une lettre: ");
var voyelle = Char.Parse(Console.ReadLine());

if (voyelle == 'a' || voyelle == 'e' || voyelle == 'i' || voyelle == 'o' || voyelle == 'u' || voyelle == 'y')
    Console.WriteLine("Cette lettre est une voyelle");

else Console.WriteLine("Cette lettre n'est pas une voyelle");