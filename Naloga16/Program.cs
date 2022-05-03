// 16.naloga: Napiši program, ki bere celo število n s tipkovnice ter izpiše na zaslon naslednji trikotnik (primer za n=4):  
// 1  4
// 1 3
// 12
// 1
//Program mora delovati samo za vhodne vrednosti iz intervala med 0 in 9.

// Ta verzija kode z if stavkom se zapre z neveljavnim vnosom
//using System;

//namespace Naloga16
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Program, ki izrise trikotnik");
//            Console.Write("Vpisi stevilo med 0 in 9: ");

//            int interval = Convert.ToInt32(Console.ReadLine());

//            Console.Write("\n");

//            if (interval >= 0 && interval <= 9)
//            {
//                for (int i = 1; i <= interval; i++)
//                {
//                    for (int j = 1; j <= interval; j++)
//                    {
//                        if (j == 1)
//                        {
//                            Console.Write("1");
//                        }
//                    }

//                    for (int k = 1; k <= interval; k++)
//                    {
//                        if (i + k == interval)
//                        {
//                            Console.Write((i - interval - 1) * (-1));
//                        }
//                        else
//                        {
//                            Console.Write(" ");
//                        }
//                    }
//                    Console.WriteLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Interval mora biti med 0 in 9");
//            }
//        }
//    }
//}



// Ta verzija kode z while stavkom se izvrsuje, dokler vnos ni pravilen
using System;

namespace Naloga16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, ki izrise trikotnik \n");
            Console.Write("Vpisi stevilo med 0 in 9: ");

            int interval = Convert.ToInt32(Console.ReadLine());

            while (!(interval >= 0 && interval <= 9))
            {
                Console.Write("Vpisi stevilo med 0 in 9: ");
                interval = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\n");

            for (int i = 1; i <= interval; i++)
            {
                for (int j = 1; j <= interval; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("1");
                    }
                }

                for (int k = 1; k <= interval; k++)
                {
                    if (i + k == interval)
                    {
                        Console.Write((i - interval - 1) * (-1));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
