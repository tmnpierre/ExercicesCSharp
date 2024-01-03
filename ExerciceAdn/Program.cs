class Program
{
    static void Main()
    {
        string adn = SaisieADN();
        string sequence = SaisieSequence();

        if (VerificationADN(adn))
        {
            decimal pourcentage = Proportion(adn, sequence);
            Console.WriteLine($"Le pourcentage d'occurrence de la séquence est de : {pourcentage:F6}%");
        }
        else
        {
            Console.WriteLine("La chaîne d'ADN n'est pas valide.");
        }
    }

    static bool VerificationADN(string adn)
    {
        foreach (char c in adn)
        {
            if (c != 'a' && c != 't' && c != 'c' && c != 'g')
            {
                return false;
            }
        }
        return true;
    }

    static string SaisieADN()
    {
        string adn;
        do
        {
            Console.WriteLine("Veuillez saisir une chaîne d'ADN (composée uniquement des lettres 'a', 't', 'c' et 'g') :");
            adn = Console.ReadLine().ToLower();
        } while (!VerificationADN(adn));

        return adn;
    }

    static string SaisieSequence()
    {
        string sequence;
        do
        {
            Console.WriteLine("Veuillez saisir une séquence d'ADN (composée uniquement des lettres 'a', 't', 'c' et 'g') :");
            sequence = Console.ReadLine().ToLower();
        } while (!VerificationADN(sequence));

        return sequence;
    }

    static decimal Proportion(string adn, string sequence)
    {
        int sequenceLength = sequence.Length;
        int occurrenceCount = 0;

        for (int i = 0; i <= adn.Length - sequenceLength; i++)
        {
            string substring = adn.Substring(i, sequenceLength);
            if (substring == sequence)
            {
                occurrenceCount++;
            }
        }

        decimal proportion = (decimal)occurrenceCount / (adn.Length - sequenceLength + 1) * 100;
        return proportion;
    }
}
