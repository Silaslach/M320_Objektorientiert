using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320
{
    internal class my_math
    {
        static int readInt()
        {
            while summe >= 0;
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int zahl))
                {
                    return zahl;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine ganze Zahl eingeben.");
                }
            }
            Console.Write("Bitte eine positive Zahl eingeben: ");
        }
        static internal int Calc_ggT(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT(b, a % b);
            }
        }

        static internal int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }


    }

}