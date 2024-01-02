DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 30, 0);
var delta = fin - DateTime.Now;
Console.ForegroundColor = ConsoleColor.DarkRed;
while (delta.TotalSeconds > 0)
{
    Console.ForegroundColor = DateTime.Now.Millisecond - 500 >= 0 ? ConsoleColor.DarkRed : ConsoleColor.Red;
    delta = fin - DateTime.Now;
    Console.Write(delta.ToString(@"hh\:mm\:ss"));
    Thread.Sleep(500);
    Console.Clear();
}
Console.WriteLine("TEMPS ECOULÉ !");
Console.ReadKey();