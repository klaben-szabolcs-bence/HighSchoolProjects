using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose mode:\na) Seperated\nb) One-line\nc) Exit");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'a': Seperated(); break;
                    case 'b': OneLine(); break;
                    case 'c': return;
                    default: Console.WriteLine("Invalid option!"); break;
                }
            } while (true);
        }
        private static void Seperated()
        {
            Console.WriteLine();
            int a, b;
            char op;
            Console.WriteLine("Enter the first number:");
            IntegerScan(out a);
            Console.WriteLine("Enter the second number:");
            IntegerScan(out b);
            Console.WriteLine("Enter the operator:");
            op = Convert.ToChar(Console.ReadLine());
            DisplayResult(a, b, op);
        }

        private static void OneLine()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter the operation with the numbers and operator seperated by space:");
                string[] pieces = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(pieces[0]);
                int b = Convert.ToInt32(pieces[2]);
                char op = Convert.ToChar(pieces[1]);
                DisplayResult(a, b, op);
            } catch
            {
                Console.WriteLine("Something went wrong. Try again.");
            }
        }

        private static void DisplayResult(int a, int b, char op)
        {
            switch (op)
            {
                case '+': Console.WriteLine("Result: {0} {1} {2} = {3}", a, op, b, a + b); break;
                case '-': Console.WriteLine("Result: {0} {1} {2} = {3}", a, op, b, a - b); break;
                case '*': Console.WriteLine("Result: {0} {1} {2} = {3}", a, op, b, a * b); break;
                case '/':
                    {
                        if (b != 0)
                            Console.WriteLine("Result: {0} {1} {2} = {3}", a, op, b, (double)a / b);
                        else Console.WriteLine("You cannot divide by zero!");
                        break;
                    }
            }
        }

        private static void IntegerScan(out int number)
        {
            bool success;
            //Console.WriteLine("Enter a number.");
            do {
                string string_value = Console.ReadLine();
                success = Int32.TryParse(string_value, out number);
                if (!success) Console.WriteLine("That's not a number.");
            } while (!success);
        }

       
    }
}
