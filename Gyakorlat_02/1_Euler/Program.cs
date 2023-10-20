using System;

namespace _1_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Euler number approximation
            double sum = 0;
            int count = 11;

            for (int i = 0; i < count; i++)
            {
                sum += 1.0 / Factorial(i);
            }

            Console.WriteLine("e = " + sum);
        }

        private static int Factorial(int number)
        {
            int factorial = 1;

            while (number > 0)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }
    }
}
