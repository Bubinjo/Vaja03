// 6.naloga: Napiši program, ki v zanki do-while prebere 10 celih števil, izračuna njihovo vsoto in jo izpiše.

using System;

namespace Naloga06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vsota = 0, i = 0;

            do
            {
                Console.Write("Vpisi celo stevilo: ");
                int x = Convert.ToInt32(Console.ReadLine());

                vsota += x;
                i++;
            } while (i < 10);

            Console.WriteLine("Vsota vseh vpisanih stevil je: {0}", vsota);
        }
    }
}
