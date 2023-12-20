// See https://aka.ms/new-console-template for more information
int age, anciennete;
double dernierSalaire, indemnite = 0;

Console.Write("Merci de saisir le dernier salaire en euros:");
dernierSalaire = double.Parse(Console.ReadLine());

Console.Write("Merci de saisir votre âge:");
age = int.Parse(Console.ReadLine());

Console.Write("Merci de saisir votre ancienneté:");
anciennete = int.Parse(Console.ReadLine());

if (anciennete <= 10)
{
    indemnite = 0.5 * dernierSalaire * anciennete;
}
else
{
    indemnite = dernierSalaire * anciennete;
}

if (age >= 46 && age <= 49)
{
    indemnite += 2 * dernierSalaire;
}
else if (age > 50)
{
    indemnite += 5 * dernierSalaire;
}

Console.WriteLine($"L'indemnité est de : {indemnite} euros");
