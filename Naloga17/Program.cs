// 17.naloga: Napiši program, ki simulira parkiršče. Število prosih mest n v parkirišču se vnese na začetku programa.
// Na začetku je parkirišče prazno. Za prihod avtomobila v parkirišče, uporabnik vnese številko 1; za izhod avtomobila iz parkirišča uporabnik vnese 2.
// Program ne sme dovoliti, da se parkira več avtomobilov, kot je kapaciteta parkirišča, prav tako mora kontrolirati, da prazno parkirišče zapusti avtomobil.
// V obeh primerih naj se izpiše ustrezno sporočilo. Če je vnos pravilen, naj se ob vsakem prihodu in odhodu prikaže število prosih mest.
// Program preneha z izvajanjem, ko uporabnik vnese 0.

using System;

namespace Naloga17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koda, ki simulira parkirisce \n");
            Console.Write("Za zacetek vnesi kapaciteto parkirisca: ");
            int kapaciteta = Convert.ToInt32(Console.ReadLine());

            while (kapaciteta <= 0)
            {
                Console.Write("Vnesena kapaciteta {0} je neveljavna. Mora biti vec kot 0: ", kapaciteta);
                kapaciteta = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Pritisni 1 za parkiranje, 2 za odhod ali 0 za konec programa: ");
            int input = 0, stevec = 0;

            while (input >= 0 || input <= 2)
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                switch (input)
                {
                    case 1:
                        {
                            if (stevec == kapaciteta)
                            {
                                Console.WriteLine("Parkirisce je polno!");
                                break;
                            }
                            else
                            {
                                stevec++;
                                Console.WriteLine("Na parkiriscu je se {0} prostih mest", kapaciteta - stevec);
                                break;
                            }
                        }
                    case 2:
                        {
                            if (stevec == 0)
                            {
                                Console.WriteLine("Parkirisce je prazno!");
                                break;
                            }
                            else
                            {
                                stevec--;
                                Console.WriteLine("Na parkiriscu je se {0} prostih mest", kapaciteta - stevec);
                                break;
                            }
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Vpisi 1 za parkiranje, 2 za odhod ali 0 za konec programa.");
                            continue;
                        }
                }
            }
        }
    }
}
