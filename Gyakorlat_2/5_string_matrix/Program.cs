using System;

namespace _5_string_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int personNumber = 3;
            string[][] matrix = new string[personNumber][];

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("E-mail number: ");
                string stringSize = Console.ReadLine();

                //todo exception handling
                int size = Convert.ToInt32(stringSize);
                matrix[i] = new string[size + 1];
                matrix[i][0] = name;

                for (int j = 1; j < size + 1; j++)
                {
                    Console.WriteLine(j + ". e-mail address: ");
                    matrix[i][j] = Console.ReadLine();
                }
            }

            List(matrix);

            Console.WriteLine(CountEmails(matrix) + " person(s) has/have more than one email address.");

            int emailNumber = CountEmails(matrix);

            switch (emailNumber)
            {
                case 0:
                    Console.WriteLine("No one has more than one email address.");
                    break;

                case 1:
                    Console.WriteLine("1 person has more than one email address.");
                    break;

                default:
                    Console.WriteLine(emailNumber + " persons have more than one email address.");
                    break;
            }
        }//main

        private static void List(String[][] matrix)
        {
            //rownumber of matrix
            int rows = matrix.Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Name: " + matrix[i][j]);
                    }
                    else
                    {
                        Console.Write(", e-mail: " + matrix[i][j]);
                    }                    
                }
                Console.WriteLine();
            }
        }

        private static int CountEmails(String[][] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Length > 2)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
