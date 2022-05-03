// 1.naloga: Napiši program, ki bo z zanko while izrisal 12 vrstic z vsebino ****. 

using System;

namespace Naloga01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            do
            {
                Console.WriteLine("****");
                x++;
            } while (x < 12);
        }
    }
}
