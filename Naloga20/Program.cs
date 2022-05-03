// 2.naloga: Napiši program, ki na vsakem koraku while zanke generira 3 naključne številke med 1 in 6 ter jih prikaže na zaslonu.
// Če sta enaki, izpiše še 'JACKPOT' in konča z delom.

using System;

namespace Naloga20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prekinitev = true;

            while (prekinitev)
            {
                Random r = new Random();
                int prvo = r.Next(1, 7);
                int drugo = r.Next(1, 7);
                int tretje = r.Next(1, 7);

                if (prvo == drugo)
                {
                    Console.WriteLine("Prvo nakljucno stevilo {0} in drugo nakljucno stevili {1} sta enaki.", prvo, drugo);
                    Console.WriteLine("JACKPOT");
                    prekinitev = false;
                    break;
                }
                else if (drugo == tretje)
                {
                    Console.WriteLine("Drugo nakljucno stevilo {0} in tretje nakljucno stevili {1} sta enaki.", drugo, tretje);
                    Console.WriteLine("JACKPOT");
                    prekinitev = false;
                    break;
                }
                else if (tretje == prvo)
                {
                    Console.WriteLine("Tretje nakljucno stevilo {0} in prvo nakljucno stevili {1} sta enaki.", tretje, prvo);
                    Console.WriteLine("JACKPOT");
                    prekinitev = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
