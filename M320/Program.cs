namespace M320
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 2;
            int b = 3;
            int summe = my_math.Calc_ggT (a, b);
            Console.WriteLine($"ggT von {a} und {b} = {summe}");
        }
    }
}
