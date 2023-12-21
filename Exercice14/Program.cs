Console.Write("Votre poids en kg: ");
int weight = Convert.ToInt32(Console.ReadLine());

Console.Write("Votre taille en cm: ");
int height = Convert.ToInt32(Console.ReadLine());

if ((weight >= 43 && weight <= 47) && (height >= 145 && height <= 159))
{
    Console.WriteLine("Prendre la taille 1");
}
else if ((weight >= 48 && weight <= 53) && (height >= 160 && height <= 163))
{
    Console.WriteLine("Prendre la taille 1");
}
else if ((weight >= 54 && weight <= 59) && (height >= 164 && height <= 172))
{
    Console.WriteLine("Prendre la taille 2");
}
else if ((weight >= 60 && weight <= 65) && (height >= 173 && height <= 175))
{
    Console.WriteLine("Prendre la taille 2");
}
else if ((weight >= 66 && weight <= 71) && (height >= 176 && height <= 178))
{
    Console.WriteLine("Prendre la taille 3");
}
else if ((weight >= 72 && weight <= 77) && (height >= 179 && height <= 183))
{
    Console.WriteLine("Prendre la taille 3");
}
else
{
    Console.WriteLine("Aucune taille ne vous correspond");
}
