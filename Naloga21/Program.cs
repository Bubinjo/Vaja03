//3.naloga: Napiši program, ki za vhodni celoštevilčni vrednosti X in n izračuna vrednost Xn.

using System;

namespace Naloga21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi stevilo: ");
            long x = Convert.ToInt64(Console.ReadLine());

            Console.Write("Vpisi potenco: ");
            long n = Convert.ToInt64(Console.ReadLine());

            long sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= x;
            }

            Console.WriteLine("Stevilo {0} na potenco {1} je: {2}", x, n, sum);
        }
    }
}
