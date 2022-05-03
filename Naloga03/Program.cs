// 3.naloga: Napiši program, ki bere cela števila tako dolgo, dokler ne vpišeš 0.
// V zanki sproti računa vsoto vrednosti vpisanih števil in na koncu izpiše povprečno vrednost na 6 celih in 2 decimalni mesti. Uporabi zanko while.

using System;

namespace Naloga03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sestevanje stevil, dokler ne vpises 0");

            int x = 1;
            double vsota = 0;
            double povprecna_vrednost = 0;
            double stevec = 0;

            while (x != 0)
            {
                Console.Write("Vpisi stevilo: ");
                x = Convert.ToInt32(Console.ReadLine());
                vsota += x;
                stevec++;
            }

            povprecna_vrednost = vsota / (stevec - 1);

            Console.WriteLine("Povprecna vrednost vpisanih stevil je: {0,6:000000.00}", povprecna_vrednost);
        }
    }
}
