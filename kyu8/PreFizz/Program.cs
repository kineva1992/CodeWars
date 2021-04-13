using System;
using System.Linq;

namespace PreFizz
{
    class Program
    {
        public static int[] PreFizz(int n) {

            int start = 1;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = start;
                start++;
            }

            return result;
        }

        public static int[] PreFizzV2(int n) {

            return Enumerable.Range(1, n).ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(PreFizzV2(5));
            Console.ReadKey();
        }
    }
}
