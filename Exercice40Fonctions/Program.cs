﻿string NomComplet(string prenom, string nom)
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

void QuelleHeure(string heure = "12h00")
{
    Console.WriteLine($"Il est {heure}"); 
}

QuelleHeure();
QuelleHeure("14h00");

void BonjourQuelleHeure(string nom, string heure = "12h00")
{
    Console.WriteLine($"Bonjour {nom} il est {heure}");
}

BonjourQuelleHeure("Benoit");
BonjourQuelleHeure("Jules", "14h00");

void BonjourQuelleHeure2(string nom, string heure = "12h00", params string[] chaines)
{
    Console.WriteLine($"Bonjour {nom} il est {heure}");
    foreach (string chaine in chaines)
    {
        Console.WriteLine(chaine);
    }
}

BonjourQuelleHeure2("Edouard");
BonjourQuelleHeure2("Jean", "14h00", "chaine1", "chaine2", "Chaine3");

BonjourQuelleHeure2(nom: "Guillaume", heure: "16h00", chaines: new string[] { "a", "b" });
BonjourQuelleHeure2(nom: "Guillaume", chaines: new string[] { "a", "b" });
BonjourQuelleHeure2("Guillaume", heure: "16h00", chaines: new string[] { "a", "b" });
static int CompteurLettreA(string chaine)
{
    int compteur = 0;
    foreach (char lettre in chaine.ToLower())
    {
        if (lettre == 'a')
        {
            compteur++;
        }
    }
    Console.Write("Resultat : ");
    return compteur;
}

Console.WriteLine(CompteurLettreA("Banana"));
Console.WriteLine(CompteurLettreA("Bonjour"));

static int CompteurLettreB(string chaine)
{
    Console.Write("Resultat : ");
    return chaine.Count(lettre => lettre == 'b' || lettre == 'B');
}

Console.WriteLine(CompteurLettreB("Bonobo"));
Console.WriteLine(CompteurLettreB("Hallo"));