string NomComplet(string prenom, string nom)
{ 
    return prenom + " " + nom;
}

Console.WriteLine(NomComplet("Joe", "Doe"));

int Soustraire(int a,  int b)
{
    Console.WriteLine($"Je soustrait {a} et {b}");
    return a - b ;
}

int sub = Soustraire(2, 1);
Console.WriteLine("Résulat : " + sub);

static string QuelleHeure(string heure = "12h00")
{
    return heure;
}

Console.WriteLine(QuelleHeure());
Console.WriteLine(QuelleHeure("14h00"));

static int CompteurLettreA(string chaine)
{
    int compteur = 0;
    foreach (char lettre in chaine)
    {
        if (lettre == 'a' || lettre == 'A')
        {
            compteur++;
        }
    }
    Console.Write("Resultat : ");
    return compteur;
}

Console.WriteLine(CompteurLettreA("Banana"));
Console.WriteLine(CompteurLettreA("Bonjour"));