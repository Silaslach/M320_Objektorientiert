﻿namespace M320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 2;
            int b = 3;
            int summe = my_math.Add (a, b);
            Console.WriteLine($"Summe von {a} und {b} mal {b} = {summe}");
        }
    }
}
