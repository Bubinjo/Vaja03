// 4.naloga: Napiši program, ki simulira igro lota: program naj generira in izpiše 6 naključnih števil med 1 in 39. Števila ne smejo biti med seboj enaka.

using System;

namespace Naloga22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prekinitev = true;

            while (prekinitev)
            {
                Random r = new Random();
                int prvo = r.Next(1, 40);
                int drugo = r.Next(1, 40);
                int tretje = r.Next(1, 40);
                int cetrto = r.Next(1, 40);
                int peto = r.Next(1, 40);
                int sesto = r.Next(1, 40);

                if ((prvo != drugo && prvo != tretje && prvo != cetrto && prvo != peto && prvo != sesto) && 
                    (drugo != prvo && drugo != tretje && drugo != cetrto && drugo != peto && drugo != sesto) && 
                    (tretje != prvo && tretje != drugo && tretje != cetrto && tretje != peto && tretje != sesto) && 
                    (cetrto != prvo && cetrto != drugo && cetrto != tretje && cetrto != peto && cetrto != sesto) && 
                    (peto != prvo && peto != drugo && peto != tretje && peto != cetrto && peto != sesto) && 
                    (sesto != prvo && sesto != drugo && sesto != tretje && sesto != peto && sesto != peto))
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4} in {5} so izbrane loto stevilke", prvo, drugo, tretje, cetrto, peto, sesto);
                    prekinitev = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
