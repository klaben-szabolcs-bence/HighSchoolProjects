using System;

namespace _4_string_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;

            IntegerScan(1, 10, out arraySize);
            Console.WriteLine();

            Console.WriteLine("Enter names:");

            string[] nameArray = new string[arraySize];
            int[] auxiliaryArray = new int[arraySize];

            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.Write(i + 1 + ". name: ");
                nameArray[i] = Console.ReadLine();
                auxiliaryArray[i] = 1;
            }

            //comparing of names
            int count = 0;

            Console.WriteLine();

            for (int i = 0; i < nameArray.Length; i++)
            {
                for (int j = i + 1; j < nameArray.Length; j++)
                {
                    if (auxiliaryArray[j] == 1 && nameArray[i].Equals(nameArray[j]))
                    {
                        Console.WriteLine("Equal: " + (i + 1) + " and " + (j + 1));

                        if (auxiliaryArray[i] == 1)
                        {
                            count++;
                            auxiliaryArray[i] = 0;
                        }

                        auxiliaryArray[j] = 0;
                        count++;
                    }
                }
            }

            Console.WriteLine("Total: " + count);

            //same initial
            count = 0;

            Console.WriteLine();

            for (int i = 0; i < nameArray.Length; i++)
            {
                for (int j = i + 1; j < nameArray.Length; j++)
                {
                    if (nameArray[i][0] == nameArray[j][0])
                    {
                        Console.WriteLine("same pair of initials: " + (i + 1) + " and " + (j + 1));
                        count++;
                    }
                }
            }

            Console.WriteLine("Total: " + count);
        }

        private static void IntegerScan(int low_value, int high_value, out int number)
        {
            //a validated reading of an int value 
            bool success;

            do
            {
                Console.WriteLine("Enter a number between " + low_value + " and " + high_value);

                do
                {
                    string string_value = Console.ReadLine();
                    success = Int32.TryParse(string_value, out number);

                    if (!success)
                        Console.WriteLine("That's not a number");

                } while (!success);

            } while (number < low_value || number > high_value);

            //Console.WriteLine("n = " + number);
        }
    }
}
