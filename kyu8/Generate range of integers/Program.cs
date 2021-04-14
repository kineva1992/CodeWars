using System;
using System.Linq;

namespace Generate_range_of_integers
{
    class Program
    {
        public static int[] GenerateRange(int min, int max, int step) => Enumerable.Range(0, (max - min) / step + 1).Select(i => min + step * i).ToArray();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var item in GenerateRange(1,10,3)) {

                Console.WriteLine($"item in {item}");

                Console.ReadKey();
            
            }
        }
    }
}
