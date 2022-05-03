// 10.naloga: Napiši program, ki bo prebral dve števili, nato pa v zanki for izpisal vsa števila med njima od manjšega proti večjemu ter od večjega proti manjšemu. 

using System;

namespace Naloga10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpisi spodnjo mejo v stevilki: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi zgornjo mejo v stevilki: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
                for (int i = y - 1; i > x; i--)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = y + 1; i < x; i++)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
                for (int i = x - 1; i > y; i--)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
