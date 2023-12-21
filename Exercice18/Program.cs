Console.Write("Indiquez l'âge de votre enfant: ");

if (int.TryParse(Console.ReadLine(), out int age))
{
    switch (age)
    {
        case 0:
            Console.WriteLine("Erreur dans la saisie");
            break;
        case < 3:
            Console.WriteLine("Votre enfant est trop jeune");
            break;
        case <= 6:
            Console.WriteLine("Votre enfant est un baby");
            break;
        case <= 8:
            Console.WriteLine("Votre enfant est un poussin");
            break;
        case <= 10:
            Console.WriteLine("Votre enfant est un pupille");
            break;
        case <= 12:
            Console.WriteLine("Votre enfant est un minime");
            break;
        case < 18:
            Console.WriteLine("Votre enfant est un cadet");
            break;
        default:
            Console.WriteLine("Ce n'est plus un enfant");
            break;
    }
}
else
{
    Console.WriteLine("Veuillez entrer un âge valide.");
}
