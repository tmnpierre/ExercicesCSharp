Console.Write("Indiquez l'âge de votre enfant: ");

if (int.TryParse(Console.ReadLine(), out int a))
{
    if (a == 0)
        Console.WriteLine("Erreur dans la saisie");
    else if (a < 3)
        Console.WriteLine("Votre enfant est trop jeune");
    else if (a >= 3 && a <= 6)
        Console.WriteLine("Votre enfant est un baby");
    else if (a >= 7 && a <= 8)
        Console.WriteLine("Votre enfant est un poussin");
    else if (a >= 9 && a <= 10)
        Console.WriteLine("Votre enfant est un pupille");
    else if (a >= 11 && a <= 12)
        Console.WriteLine("Votre enfant est un minime");
    else if (a >= 13 && a < 18)
        Console.WriteLine("Votre enfant est un cadet");
    else if (a >= 18)
        Console.WriteLine("Ce n'est plus un enfant");
}
else
{
    Console.WriteLine("Veuillez entrer un âge valide.");
}
