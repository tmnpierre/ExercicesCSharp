Console.Write("Entrez la longueur de AB en cm:");
double ab = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longueur de BC en cm:");
double bc = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longueur de CA en cm:");
double ca = Convert.ToDouble(Console.ReadLine());

if (ab == bc && bc == ca)
{
    Console.WriteLine("Le triangle est équilatéral.");
}
else if (ab == ca && ab != bc)
{
    Console.WriteLine("Le triangle est isocèle en A mais pas équilatéral.");
}
else if (ab == bc && ab != ca)
{
    Console.WriteLine("Le triangle est isocèle en B mais pas équilatéral.");
}
else if (ca == bc && ca != ab)
{
    Console.WriteLine("Le triangle est isocèle en C mais pas équilatéral.");
}
else
{
    Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.");
}
