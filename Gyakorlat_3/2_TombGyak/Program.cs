using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TombGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = RandomArray();
            PrintArray(array);
            Console.WriteLine("Legnagyobb páros szám: " + MaxEvenNumber(array));
        }

        static int[] RandomArray()
        {
            Random r = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = r.Next(1,51);
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("The array: ");
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("");
        }

        static int MaxEvenNumber(int[] arr)
        {
            return arr.Where((a) => { return a % 2 == 0; }).Max();
        }
    }
}
