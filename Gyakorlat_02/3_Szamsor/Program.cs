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
            int number;

            IntegerScan(1, 9, out number);
            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; ; j++)
                {
                    //Console.Write(i + " ");
                    Console.Write("{0,-2:G}", i);
                    //Console.Write($"{i,-2:G}");

                    if (i == j)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,-2:G}", i);
                }

                Console.WriteLine();
            }


        }

        private static void IntegerScan(int low_value, int high_value, out int number)
        {
            //a validated reading of an int value 
            bool success;

            do
            {
                Console.WriteLine("Enter a number between " + low_value + " and " + high_value);
                //Console.WriteLine($"Enter a number between {low_value} and {high_value}");

                do
                {
                    string string_value = Console.ReadLine();
                    success = Int32.TryParse(string_value, out number);

                    if (!success)
                        Console.WriteLine("That's not a number.");

                } while (!success);

            } while (number < low_value || number > high_value);

            //Console.WriteLine("n = " + number);
        }
    }
}
