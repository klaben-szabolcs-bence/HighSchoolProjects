using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Szamsor
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            EgeszBekerese(1, 9, out szam);

            for (int i = 1; i < szam; i++)
            {
                for (int j = 0; ; j++)
                {
                    Console.WriteLine($"{i} ");
                    if (i == j) { Console.WriteLine();  return; }
                }
            }
        }

        private static void EgeszBekerese(int also_hatar, int felso_hatar, out int szam)
        {
            string sztring;
            bool sikeres_atalakitas;
            do
            {
                Console.WriteLine("Kérem adjon meg egy számot!");

                do
                {
                    sztring = Console.ReadLine();
                    sikeres_atalakitas = Int32.TryParse(sztring, out szam);

                    if (!sikeres_atalakitas)
                    {
                        Console.WriteLine($"{also_hatar} és {felso_hatar} közé eső szám kell!");
                    }

                } while (!sikeres_atalakitas);

            } while (szam < also_hatar || szam > felso_hatar);
        }
    }
}
