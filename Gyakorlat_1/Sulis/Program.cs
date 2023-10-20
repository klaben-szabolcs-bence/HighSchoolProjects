using System;

namespace LeibnizFeleSor
{
    /// <summary>
    /// Futtatható osztály
    /// </summary>
    class Program
    {
        /// <summary>
        /// Belépési pont
        /// </summary>
        /// <param name="args">Paraméterek</param>
        static void Main(string[] args)
        {
            //Leibniz-féle sor
            int szamlalo = 1, nevezo = 1, iteraciok_szama = 10000;
            double pi = 0;
            for (int i = 1; i < iteraciok_szama; i++)
            {
                if (i % 2 == 1)
                    pi += (double)szamlalo / nevezo;
                else
                    pi -= (double)szamlalo / nevezo;

                nevezo += 2;
            }

            Console.WriteLine("Pi értéke: {0:0.00000}", pi*4);

            //Wallis szuma
            szamlalo = 0; nevezo = 1; pi = 1;

            for (int i = 1; i < iteraciok_szama; i++)
            {
                if (i % 2 == 1)
                    szamlalo += 2;
                else
                    nevezo += 2;

                pi *= (double)szamlalo / nevezo;
            }

            Console.WriteLine("Pi értéke: {0:F5}", pi*2);
        }
    }
}
