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
            int[] array = RandomIntArray();
            PrintArray(array);
            Console.WriteLine("Largest even number: " + MaxEvenNumber(array));
            Console.WriteLine("Count of square numbers: " + SquareNumberCount(array));
            double[] d_array = RandomDoubleArray();
            Console.WriteLine("Geometric avarage: " + GeometricAvg(array));
            
            // There could be other types of array functions here, but I'm too lazy :shrug:
        }

        static int[] RandomIntArray()
        {
            Random r = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = r.Next(1,51);
            return arr;
        }
        static double[] RandomDoubleArray()
        {
            Random r = new Random();
            double[] arr = new double[10];
            for (int i = 0; i < 10; i++)
                arr[i] = r.Next(1, 51);
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

        static int SquareNumberCount(int[] arr)
        {
            return arr.Where((a) => { return Math.Sqrt(a) == (int)Math.Sqrt(a); }).Count();
        }

        static double GeometricAvg(int[] arr)
        {
            double product = 1;
            foreach (var item in arr)
            {
                product *= item;
            }
            return Math.Pow(product, 1.0 / arr.Length);
        }
    }
}
