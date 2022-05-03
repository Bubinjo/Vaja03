// 2.naloga: Napiši program, ki bo izpisal prvih 15 večkratnikov vpisanega števila, vsakega v svojo vrstico. Uporabi zanko while. 

using System;

namespace Naloga02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, ki izpise prvih 15 veckratnikov.");
            Console.Write("Vpisi stevilo: ");
            Console.Write("\n");

            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i < 16) {
                Console.WriteLine("{0}.veckratnik je: {1}", i, x * i);
                i++;
            }
        }
    }
}
