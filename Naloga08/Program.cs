// 8.naloga: Napiši program, ki bere znake in šteje, koliko je velikih črk, koliko malih črk in koliko ostalih znakov.
// Z branjem naj preneha, ko prebere 20 znakov. Pred koncem izpiše, kar je preštel. Uporabi zanko do-while.

using System;

namespace Naloga08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int male_crke = 0, velike_crke = 0, ostalo = 0;

            do
            {
                Console.Write("Vpisi znak: ");
                char x = Convert.ToChar(Console.ReadLine());

                if (x >= 'a' && x <= 'z')
                {
                    male_crke++;
                }
                else if (x >= 'A' && x <= 'Z')
                {
                    velike_crke++;
                }
                else
                {
                    ostalo++;
                }

                i++;
            } while (i < 20);

            Console.WriteLine("Vpisal si {0} malih crk, {1} velikih crk in {2} ostalih znakov.", male_crke, velike_crke, ostalo);
        }
    }
}
