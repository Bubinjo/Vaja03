// 5.naloga: Napiši program, ki vhodno celo število n obrne! Npr. za vhodno število n=2413, program izpiše 3142. Uporabi numerično metodo (glej nalogo 18)!

using System;

namespace Naloga23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi celo stevilo: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;

            int result = 0;
            while (x > 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }

            Console.WriteLine("Obratni vrstni red stevilke {0} je: {1}", y, result);
        }
    }
}
