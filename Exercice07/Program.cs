Console.WriteLine("--- Calcul de la longueur de l'hypothénuse --- \n");
Console.Write("Entrez la longueur du premier coté en cm: ");
var a = double.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du deuxième côté en cm: ");
var b = double.Parse(Console.ReadLine());
var hyp =  (a * a) + (b * b);
Console.WriteLine($"La longueur de l'hypothénuse est de {hyp} cm");