using System;

namespace HelloWorld
{
    internal class my_math
    {
        // Berechnet den grössten gemeinsamen Teiler (ggT) iterativ mit dem Euklidischen Algorithmus
        static internal int Calc_ggT(int a, int b)
        {
            while (b != 0) // solange b nicht 0 ist, weiterrechnen
            {
                int z = a % b; // Rest der Division
                a = b;         // b wird neuer Dividend
                b = z;         // Rest wird neuer Divisor
            }
            return a; // ggT ist erreicht, wenn Rest = 0
        }

        // Berechnet den ggT rekursiv (gleicher Algorithmus, nur mit Rekursion)
        static internal int Calc_ggT_r(int a, int b)
        {
            if (b == 0)         // Abbruchbedingung: wenn b = 0, ist a der ggT
                return a;
            return Calc_ggT_r(b, a % b); // Rekursiver Aufruf mit vertauschten Werten
        }

        // Berechnet das kleinste gemeinsame Vielfache (kgV)
        static internal int Calc_kgv(int a, int b)
        {
            if (a == 0 || b == 0) return 0; // Wenn eine Zahl 0 ist, gibt es kein kgV
            int ggt = Calc_ggT(a, b);       // Erst ggT berechnen
            return (a / ggt) * b;           // Formel: (a * b) / ggT
        }

        // Liest eine positive ganze Zahl von der Konsole ein
        static internal int ReadInt()
        {
            int value;
            while (true) // solange bis eine gültige Zahl eingegeben wird
            {
                Console.Write("Bitte eine positive ganze Zahl eingeben: ");
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value; // Erfolgreiche Eingabe

                Console.WriteLine("Ungültige Eingabe! Zahl muss > 0 sein.");
            }
        }

        // Gibt ein formatiertes Ergebnis zurück
        static internal string ShowResult(string type, int a, int b, int result)
        {
            return $"{type} von {a} und {b} ist {result}";
        }

        // Liest ein Array von Zahlen vom Benutzer ein
        static internal int[] ReadArray()
        {
            Console.Write("Wie viele Zahlen möchten Sie eingeben? ");
            int n = ReadInt();          // Anzahl Elemente bestimmen
            int[] arr = new int[n];     // Array erzeugen

            for (int i = 0; i < n; i++) // Schleife: n-mal Zahl eingeben
            {
                arr[i] = ReadInt();
            }

            return arr; // fertiges Array zurückgeben
        }

        // Berechnet den Durchschnitt aller Zahlen im Array
        static internal double Avg(int[] arr)
        {
            double sum = 0;
            foreach (int val in arr) sum += val; // alle Werte addieren
            return sum / arr.Length;             // durch Anzahl teilen
        }

        // Sucht das Minimum im Array
        static internal int Min(int[] arr)
        {
            int min = arr[0]; // Startwert = erstes Element
            foreach (int val in arr) if (val < min) min = val; // kleineren Wert merken
            return min;
        }

        // Sucht das Maximum im Array
        static internal int Max(int[] arr)
        {
            int max = arr[0]; // Startwert = erstes Element
            foreach (int val in arr) if (val > max) max = val; // grösseren Wert merken
            return max;
        }

        // Vertauscht die Werte zweier Variablen (per Referenz übergeben)
        static internal void Swap(ref int a, ref int b)
        {
            int temp = a; // Zwischenspeicher
            a = b;
            b = temp;
        }
    }
}
