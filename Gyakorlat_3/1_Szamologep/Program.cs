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
            Console.WriteLine("Choose mode:\na) Seperated\nb)One-line\nc)Exit");
            do
            {
                switch(Console.ReadKey().KeyChar)
                {
                    case 'a': Seperated(); break;
                    case 'b': OneLine(); break;
                    case 'c': return;
                    default: Console.WriteLine("Invalid option!"); break;
                }
            } while (true);
        }

        private static void OneLine()
        {
            throw new NotImplementedException();
        }

        private static void IntegerScan(out int number)
        {
            bool success;
            Console.WriteLine("Enter a number.");
            do {
                string string_value = Console.ReadLine();
                success = Int32.TryParse(string_value, out number);
                if (!success) Console.WriteLine("That's not a number.");
            } while (!success);
        }

        private static void Seperated()
        {

        }
    }
}
