Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré --- \n");
Console.Write("Entré la longueur d'un côté du triangle en cm: ");
var a = double.Parse(Console.ReadLine());
var area = a * a;
var perimeter = 4 * a;
Console.WriteLine($"Le périmètre du carré est : {perimeter} cm");
Console.WriteLine($"L'air du carré est : {area} cm2");

Console.WriteLine();

Console.WriteLine("--- Calcul du périmètre et de l'aire d'un rectangle --- \n");
Console.Write("Entrez la longueur du rectangle en cm: ");
var c = double.Parse(Console.ReadLine());
Console.Write("Entrez la largeur du rectangle en cm: ");
var  d = double.Parse(Console.ReadLine());

Console.WriteLine();
var area2 = c * d; 
var perimeter2 = (c + d) * 2;
Console.WriteLine($"Le périmètre du rectangle est : {perimeter2} cm");
Console.WriteLine($"L'air du rectangle est : {area2} cm2");