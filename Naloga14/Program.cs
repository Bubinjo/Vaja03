// 14.naloga: Napiši program, ki bo v for zanki bral pozitivna cela števila s tipkovnice ter izpisal največje med njimi.
// Branje končamo, ko uporabnik število, ki je manjše ali enako 0.
// 
// Primer: če vnesemo števila 12, 5, 9, 43, 10, 0, naj se izpiše 43.

using System;

namespace Naloga14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            for (int i = 0; i < 10; i--)
            {
                int y = Convert.ToInt32(Console.ReadLine());

                if (y >= x)
                {
                    x = y;
                }

                if (y <= 0)
                {
                    break;
                }
            }

            Console.WriteLine("\n" + x);
        }
    }
}
