class Program
{
    static (double, double, double, double) operation(double a, double b)
    {
        double somme = a + b;
        double difference = a - b;
        double quotient = a / b;
        double produit = a * b;
        return (somme, difference, quotient, produit);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Entrez deux nombres :");

        double nombre1, nombre2;

        Console.Write("Nombre 1 : ");
        if (!double.TryParse(Console.ReadLine(), out nombre1))
        {
            Console.WriteLine("Entrée invalide pour le nombre 1.");
            return;
        }

        Console.Write("Nombre 2 : ");
        if (!double.TryParse(Console.ReadLine(), out nombre2))
        {
            Console.WriteLine("Entrée invalide pour le nombre 2.");
            return;
        }

        var result = operation(nombre1, nombre2);

        Console.WriteLine($"Somme : {result.Item1}");
        Console.WriteLine($"Différence : {result.Item2}");
        Console.WriteLine($"Quotient : {result.Item3}");
        Console.WriteLine($"Produit : {result.Item4}");
    }
}
