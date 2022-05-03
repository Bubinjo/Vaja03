// 1.naloga: Napiši program, ki na zaslon 'izriše' naslednji vzorec (primer. za n=4):
//    1
//   22
//  3 3
// 4  4
// Program mora delovati samo za vhodne vrednosti iz intervala med 0 in 9.

using System;

namespace Naloga19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koda, ki izrise trikotnik. \n");
            Console.Write("Vnesi celo stevilo med 0 in 9: ");
            int interval = Convert.ToInt32(Console.ReadLine());

            while (interval >= 0 && interval <= 9)
            {
                for (int i = 1; i <= interval; i++)
                {
                    for (int j = 1; j < interval; j++)
                    {
                        if (j == interval - i + 1)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    for (int k = 1; k <= interval; k++)
                    {
                        if (k == interval)
                        {
                            Console.Write(i);
                        }
                    }
                    Console.WriteLine();
                }
                break;
            }
        }
    }
}
