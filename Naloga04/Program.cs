// 4.naloga: Napiši program, ki v zanki omogoča vpis ocen in s pomočjo stavka switch-case prešteva, koliko 1, 2, 3, 4 in 5 je bilo vpisanih.
// Vpis končaš z 0. Pred koncem programa naj se izpiše število doseženih ocen (posamezno po ocenah) in povprečje ocen! Uporabi zanko while.

using System;

namespace Naloga04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpis ocen");
            Console.Write("\n");

            double x = 1, stevec_1 = 0, stevec_2 = 0, stevec_3 = 0, stevec_4 = 0, stevec_5 = 0;
            double povprecje_ocen = 1;

            while (x > 0 && x < 6)
            {
                x = Convert.ToDouble(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        stevec_1++;
                        break;
                    case 2:
                        stevec_2++;
                        break;
                    case 3:
                        stevec_3++;
                        break;
                    case 4:
                        stevec_4++;
                        break;
                    case 5:
                        stevec_5++;
                        break;
                }
            }

            povprecje_ocen = (stevec_1 * 1 + stevec_2 * 2 + stevec_3 * 3 + stevec_4 * 4 + stevec_5 * 5) / (stevec_1 + stevec_2 + stevec_3 + stevec_4 + stevec_5);

            Console.WriteLine("Nezadostnih 1 je bilo: {0}", stevec_1);
            Console.WriteLine("Zadostnih 2 je bilo: {0}", stevec_2);
            Console.WriteLine("Dobrih 3 je bilo: {0}", stevec_3);
            Console.WriteLine("Prav dobrih 4 je bilo: {0}", stevec_4);
            Console.WriteLine("Odlicnih 5 je bilo: {0}", stevec_5);
            Console.WriteLine("Povprecje vseh ocen je: {0}", povprecje_ocen);
        }
    }
}
