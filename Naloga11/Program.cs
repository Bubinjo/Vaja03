// 11.naloga: Napiši program, ki bo prebral tri števila a, b in k, nato pa v zanki for izpisal vsa števila med a in b s korakom k
// (razlika med izpisanimi števili je k). 

using System;

namespace Naloga11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, ki izpise interval stevil s korakom.");
            Console.Write("\n");

            Console.Write("Vpisi prvo stevilo: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi drugo stevilo: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpisi korak: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                for (int i = x; i < y; i += k)
                {
                    Console.Write(i + " ");
                }
            }

            if (y < x)
            {
                for (int i = y; i < x; i += k)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
