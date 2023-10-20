using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            double eulerSzam = 0;
            int darabszam = 11;

            for (int i = 0; i < darabszam; i++)
            {
                eulerSzam += 1.0 / Faktorialis(i);
            }

            Console.WriteLine("e = {0}", eulerSzam);
        }

        private static double Faktorialis(int szam)
        {
            int faktorialis = 1;

            while (szam > 0)
            {
                faktorialis *= szam;
                szam--;
            }
            return faktorialis;
        }
    }
}
