// 5.naloga: Ugotovite, kaj izpiše naslednji del programa: 

// i = 11;
// do
// {
//    Console.Writeline(++i - 11);
// } while (i < 21);

using System;

namespace Naloga05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 11;

            do
            {
                Console.WriteLine(++i - 11);
            }   while (i < 21);
        }
    }
}
