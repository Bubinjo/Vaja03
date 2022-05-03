// 12.naloga: Napiši program, ki bo z zanko for generiral 100 naključnih števil in jih izpisal. 
// Uporabi: 
// Random r = new Random();
// int st = r.Next(100);

using System;

namespace Naloga12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                int rand = r.Next(100);

                Console.WriteLine("{0}. nakljucno stevilo je: {1}", i+1, rand);
            }
        }
    }
}
