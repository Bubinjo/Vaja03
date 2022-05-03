// 9.naloga: Napiši program, ki si »izmisli« naključno število med 1 in 100. Uporabnik v zanki do-while ugiba število. Program mu pri vsakem vpisu števila pove, 
// ali je iskano število večje ali manjše od vpisanega, oziroma ali je enako. Če je enako, se zanka konča, program pa izpiše, koliko poskusov je uporabnik potreboval, nato pa se zaključi.
// Naključno število generiraš takole: 
// Random r = new Random();
// int st = r.Next(1, 101);

using System;

namespace Naloga09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ugani nakljucno stevilo med 1 in 100");
            Console.Write("\n");

            int x, stevec = 0;
            Random rnd = new Random();
            int nakljucno = rnd.Next(1, 101);

            do
            {
                Console.Write("Vpisi stevilko: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x < nakljucno)
                {
                    Console.WriteLine("Nakljucno stevilo je vecje!");
                }

                if (x > nakljucno)
                {
                    Console.WriteLine("Nakljucno stevilo je manjse!");
                }

                stevec++;
            } while (x != nakljucno);

            Console.WriteLine("Uganil si nakljucno stevilo! Rabil si {0} poskusov", stevec);
        }
    }
}
