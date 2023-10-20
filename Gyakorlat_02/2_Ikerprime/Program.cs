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
            //a validated reading of an int value 
            string string_value;
            int number;
            int low_value = 1;
            int high_value = 10;
            bool success;

            do
            {
                Console.WriteLine($"Enter a number between {low_value} and {high_value}.");

                do
                {
                    string_value = Console.ReadLine();
                    success = Int32.TryParse(string_value, out number);

                    if (!success)
                        Console.WriteLine("That's not a number.");

                } while (!success);

            } while (number < low_value || number > high_value);

            Console.WriteLine("n = " + number);

            int count = 0;

            for (int i = 10, j = i + 1; count < number; i++, j++)
            {
                //relatively prime, mutually prime, or coprime
                if (Coprime(i, j))
                {
                    Console.WriteLine("(" + i + ", " + j + ")");
                    count++;
                }
            }

            Console.WriteLine();

            int start_number = 10;
            int stop_number = 20;
            count = 0;

            for (int i = start_number; count < number; i++)
            {
                for (int j = i + 1; j < stop_number; j++)
                {
                    //relatively prime, mutually prime, or coprime
                    if (Coprime(i, j))
                    {
                        //Console.WriteLine("(" + i + "," + j + ")");
                        Console.WriteLine($"({i}, {j})");
                        count++;

                        if (count == number)
                        {
                            break;
                        }
                    }
                }
            }
        }//Main

        private static bool Coprime(int x, int y)
        {
            if (GreatestCommonDivisor(x, y) == 1)
                return true;
            else
                return false;
        }

        private static int GreatestCommonDivisor(int x, int y)
        {
            while (y != 0)
            {
                int temporary = y;
                y = x % y;
                x = temporary;
            }

            return x;
        }
    }
}
