using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Ett allvarligt fel har inträffat på din dator.");
        Console.WriteLine("Datorn kommer att stängas av om några ögonblick.");
        Console.WriteLine("Vänta tålmodigt...");

        // Simulera en fördröjning innan datorn stängs av
        Thread.Sleep(5000);

        Console.Clear();
        Console.WriteLine("Datorn har stängts av på grund av ett allvarligt fel.");
    }
}
