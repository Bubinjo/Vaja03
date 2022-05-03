// 7.naloga: Napiši program, ki v zanki do-while prebere 20 realnih števil in izpiše (formatirano na 6 celih in dve decimalni mesti) ločeno vsoto pozitivnih in vsoto negativnih števil.

using System;

namespace Naloga07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vsota pozitivnih in negativnih stevil");

            int i = 0;
            double pozitivna = 0, negativna = 0;

            do
            {
                Console.Write("Vpisi stevilo: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (x < 0)
                {
                    negativna += x;
                }
                else
                {
                    pozitivna += x;
                }

                i++;
            } while (i < 20);

            Console.WriteLine("Vsota vseh pozitivnih stevil je: {0, 6:000000.00}", pozitivna);
            Console.WriteLine("Vsota vseh negativnih stevil je: {0, 6:000000.00}", negativna);
        }
    }
}
