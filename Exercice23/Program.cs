Console.WriteLine("--- Accroissement de la population ---");
Console.WriteLine();

double tauxDeCroissance = 0.89 / 100; 
int populationActuelle = 96809;
int populationCible = 120000;
int anneeDepart = 2015;
int annee;

for (annee = anneeDepart; populationActuelle <= populationCible; annee++)
{
    populationActuelle += (int)(populationActuelle * tauxDeCroissance);
}


Console.WriteLine($"Il faudra {annee - anneeDepart} années pour dépasser {populationCible} habitants.");
Console.WriteLine($"Il y aura {populationActuelle} habitants en l'année {annee}.");