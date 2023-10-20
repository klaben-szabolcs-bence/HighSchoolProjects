using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ikerprime
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Kijavítani

            int szam;
            int also_hatar = 1, felso_hatar = 10;
            string sztring_ertek;
            bool sikeres_atalakitas;

            do
            {
                Console.WriteLine("Kérem adjon meg egy számot!");

                do
                {
                    sztring_ertek = Console.ReadLine();
                    sikeres_atalakitas = Int32.TryParse(sztring_ertek, out szam);

                    if (!sikeres_atalakitas)
                    {
                        Console.WriteLine($"{also_hatar} és {felso_hatar} közé eső szám kell!");
                    }

                } while (!sikeres_atalakitas);

            } while (szam < also_hatar || szam > felso_hatar);

            Console.WriteLine(szam);

            int talatdarabszam = 0;

            for (int i = 20, j = i + 1; talatdarabszam < szam; i++, j++)
            {
                if (RelativPrim(i, j))
                {
                    Console.WriteLine($"({i}, {j})");
                }
            }
        }

        private static bool RelativPrim(int x, int y)
        {
            if (LegnagyobbKozosOszto(x, y) == 1) return true;
            else return false;
        }

        private static int LegnagyobbKozosOszto(int x, int y)
        {
            while (y != 0 )
            {
                int ideiglenes = y;
                y = x % y;
                x = ideiglenes;
            }

            return x;
        }
    }
}
