using System;
using System.Linq;

namespace Sort_Numbers
{
    /*Finish the solution so that it sorts the passed in array of numbers. 
     * If the function passes in an empty array or null/nil value then it should return an empty array.*/

    class Program
    {
        public static int[] SortNumbers(int[] nums)
        {
            return nums?.OrderBy(x => x).ToArray() ?? new int[0];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
