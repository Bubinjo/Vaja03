// 15.naloga: Z uporabo zanke v zanki napiši program, ki izpiše trikotnik števil naslednje oblike: 
// 1
// 21
// 321
// 4321
// 54321
// 654321
// 7654321
// 87654321
// 987654321

using System;

namespace Naloga15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
