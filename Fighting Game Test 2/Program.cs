using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string dateiname = "data"; // Dateiname ohne Pfad

        string aktuellesVerzeichnis = Directory.GetCurrentDirectory();
        string dateipfad = Path.Combine(aktuellesVerzeichnis, dateiname);

        if (File.Exists(dateipfad))
        {
            try
            {
                string[] lines = File.ReadAllLines(dateipfad);

                // Hier können Sie die Daten weiterverarbeiten
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Lesen der Datei: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Console.ReadKey();
    }
}
class Addon
{
    public static void TurnToLifebar(int i, int s, bool line)
    {
        Console.Write("[");
        for (int turns = 0; turns < (s / 10); turns++)
        {
            Console.ResetColor();
            if (i > (turns * 10))
            {
                if (turns <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("#");
                }
                else if (turns <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#");
                }
                else if ((turns < (s / 10)))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#");
                }
                else if ((turns * 10) < i)
                {
                    Console.Write("-");
                }
            }
            else
            {
                Console.ResetColor();
                Console.Write("-");
            }
        }
        Console.ResetColor();
        Console.Write("]");
        if (line)
        {
            Console.WriteLine();
        }
    }
    public static int CheckMax(int i, int max)
    {
        if (i > max)
        {
            i = max;
        }
        if (i < 0)
        {
            i = 0;
        }
        return i;
    }
    public static void LoadingSymbol(int turns, int wait)
    {
        for (int i = 0; i < turns; i++)
        {
            Console.Write("|");
            Thread.Sleep(wait);
            Console.Clear();
            Console.Write("/");
            Thread.Sleep(wait);
            Console.Clear();
            Console.Write("-");
            Thread.Sleep(wait);
            Console.Clear();
            Console.Write("\\");
            Thread.Sleep(wait);
            Console.Clear();
        }
    }
}