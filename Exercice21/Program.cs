Console.WriteLine("Tables of contents: ");

for (int chapter = 1; chapter <= 3; chapter++)
{
    Console.WriteLine($"Chapter {chapter}");
    for (int subPart = 1; subPart <= 3; subPart++)
    {
        Console.WriteLine($"\tSubpart {chapter}.{subPart}");
    }
}