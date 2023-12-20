Console.Write("Entrez le prix HT de l'objet (en Euros): ");
var a = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux de TVA (en %): ");
var b = double.Parse(Console.ReadLine());
var c = (a * b)/100;
Console.WriteLine($"Le montant de la TVA est de: {c} Euros");
var d = a + c;
Console.WriteLine($"Le prix TTC est de : {d} Euros");