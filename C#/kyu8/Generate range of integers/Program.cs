using System;
using System.Linq;

namespace Generate_range_of_integers
{
    /*Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with the step. The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max)

    Task
    Implement a function named

    GenerateRange(2, 10, 2) == new int[]{ 2, 4, 6, 8, 10 }
    GenerateRange(1, 10, 3) == new int[]{ 1, 4, 7, 10 }
    Note
    min < max
    step > 0
    the range does not HAVE to include max (depending on the step)*/
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
