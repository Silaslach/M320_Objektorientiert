using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Begrüssung des Benutzers
            Console.WriteLine("Willkommen zum ggT/kgV-Rechner!");

            bool weiter = true; // Steuert, ob das Programm wiederholt wird
            while (weiter)
            {
                // Liest zwei ganze Zahlen vom Benutzer ein
                int a = my_math.ReadInt();
                int b = my_math.ReadInt();

                // Fragt, ob ggT oder kgV berechnet werden soll
                Console.WriteLine("Möchten Sie ggT oder kgV berechnen? (ggt/kgv) ");
                string choice = Console.ReadLine().Trim().ToLower(); // Eingabe bereinigen und in Kleinbuchstaben umwandeln

                if (choice == "ggt")
                {
                    // ggT sowohl iterativ als auch rekursiv berechnen
                    int ggt = my_math.Calc_ggT(a, b);
                    int ggt_r = my_math.Calc_ggT_r(a, b);

                    // Ergebnis ausgeben
                    Console.WriteLine(my_math.ShowResult("ggt", a, b, ggt));
                    Console.WriteLine($"rekursiv berechnet: {ggt_r}");
                }
                else if (choice == "kgv")
                {
                    // kgV berechnen
                    int kgv = my_math.Calc_kgv(a, b);

                    // Ergebnis ausgeben
                    Console.WriteLine(my_math.ShowResult("kgv", a, b, kgv));
                }
                else
                {
                    // Ungültige Eingabe behandeln
                    Console.WriteLine("Ungültige Auswahl!");
                }

                // Fragt den Benutzer, ob er eine neue Berechnung durchführen will
                Console.Write("Neue Berechnung? (j/n): ");
                string answer = Console.ReadLine().Trim().ToLower();

                // Falls keine neue Berechnung gewünscht, Schleife beenden
                if (answer != "j")
                {
                    weiter = false;
                }
            }

            // Array-Funktionalitäten testen
            Console.WriteLine("\n--- Array Test ---");
            int[] arr = my_math.ReadArray(); // Benutzer gibt ein Array ein
            Console.WriteLine($"Mittelwert: {my_math.Avg(arr)}"); // Durchschnitt berechnen
            Console.WriteLine($"Kleinster Wert: {my_math.Min(arr)}"); // Minimum berechnen
            Console.WriteLine($"Grösster Wert: {my_math.Max(arr)}"); // Maximum berechnen

            // Swap-Funktion testen
            Console.WriteLine("\n--- Swap Test ---");
            int x = 5, y = 10;
            Console.WriteLine($"Vor Swap: x={x}, y={y}");
            my_math.Swap(ref x, ref y); // Werte vertauschen
            Console.WriteLine($"Nach Swap: x={x}, y={y}");

            // Programmende
            Console.WriteLine("Programm beendet.");
        }
    }
}
