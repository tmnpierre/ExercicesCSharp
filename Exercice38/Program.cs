var tab = new int[10];
int valeur;
Random aleatoire = new Random();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Saisir la valeur {i + 1} : ");
    valeur = aleatoire.Next(1, 51);
    tab[i] = valeur;
}