using System;

namespace Ikerprimek
{
    class Program
    {
        static void Main(string[] args)
        {
            int also = 1, felso = 100;

            for (int i = also; i < felso; i++)
            {
                for (int j = i + 1; j <= felso; j++)
                {
                    if (IkerPrimE(i, j))
                    {
                        Console.WriteLine($"({i}, {j})");
                    }
                }
            }
        }

        private static bool IkerPrimE(int x, int y)
        {
            if (PrimE(x) && PrimE(y) && Kulombseg(x, y) == 2) return true;
            else return false;
        }

        private static int Kulombseg(int x, int y)
        {
            return Math.Abs(x - y);
        }

        private static bool PrimE(int szam)
        {
            if (szam < 2) return false;

            for (int i = 2; i < szam / 2; i++)
            {
                if (szam % 2 == 0) return false;
            }

            return true;
        }
    }
}
