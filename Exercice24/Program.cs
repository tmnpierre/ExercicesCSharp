Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

for (int i = 1; i <= nombre / 2; i++)
{

    for (int j = i; j <= nombre ; j++)
    {
        int somme = 0;
        string suite = "";

        for (int k = i; k <= j; k++)
        {
            somme += k;
            suite += k.ToString();

            if (k < j)
            {
                suite += " + ";
            }
        }

        if (somme == nombre)
        {
            Console.WriteLine(suite + " = " + somme);
        }

    }
}