// 13.naloga: Napiši program, ki bo z zanko for generiral 1000 naključnih števil med -1000 in +1000, nato pa bo izpisal, koliko je bilo negativnih števil, 
// koliko pozitivnih in koliko ničel. Izpisal bo tudi seštevek vseh števil ter posebej seštevek vseh pozitivnih števil ter absolutnih vrednosti vsehnegativnih števil. 
// Uporabi: 
// Random r = new Random();
// int st = r.Next(-1000, 1001);

using System;

namespace Naloga13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitivna_sum = 0, negativna_sum = 0, pozitivna_stevec = 0, negativna_stevec = 0, nicle_stevec = 0, sum_vse = 0, abs_vrednost = 0;

            for (int i = 0; i < 1000; i++)
            {
                Random r = new Random();
                int rand = r.Next(-1000, 1001);

                if (rand > 0)
                {
                    pozitivna_stevec++;
                    pozitivna_sum += rand;
                }
                if (rand < 0)
                {
                    negativna_stevec++;
                    negativna_sum += rand;
                    abs_vrednost += rand;
                }
                if (rand == 0)
                {
                    nicle_stevec++;
                }
            }

            abs_vrednost *= -1;
            sum_vse = pozitivna_sum + negativna_sum;

            Console.WriteLine("Vseh pozitivnih stevil je bilo {0}, njihova vsota je {1}.", pozitivna_stevec, pozitivna_sum);
            Console.WriteLine("Vseh negativnih stevil je bilo {0}, njihova vsota je {1}.", negativna_stevec, negativna_sum);
            Console.WriteLine("Sestevek vseh stevil je {0}", sum_vse);
            Console.WriteLine("Vseh nicel je bilo {0}", nicle_stevec);
            Console.WriteLine("Absolutna vrednost vseh negativnih stevil je {0}", abs_vrednost);
        }
    }
}
