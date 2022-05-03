// 18.naloga: Napiši program, ki sešteje števke vnešenega celega števila: npr.za vhodno število n=2413, program izračuna in izpiše 10; za vhodno število n=123,
// program izračuna in izpiše 6.

using System;

namespace Naloga18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpisi stevilo in dobis sestevek stevk");

            int input = Convert.ToInt32(Console.ReadLine());
            int x = input;
            int sum = 0;

            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }

            Console.WriteLine("Sestevek stevk stevilke {0} je {1}", input, sum);
        }
    }
}
