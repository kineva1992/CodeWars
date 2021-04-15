using System;
using System.Linq;

namespace Convert_number_to_reversed_array_of_digits
{
    /*
     Convert number to reversed array of digits
     Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
     */

    public static long[] Digitize(long n)
    {
        int[] nnumber = new int[n];

        var longs = nnumber.Select(item => (long)item).ToArray();
        return longs;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
