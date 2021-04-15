using System;
using System.Linq;

namespace PreFizz
{
    /*This is the first step to understanding FizzBuzz.
    Your inputs: a positive integer, n, greater than or equal to one. n is provided, you have NO CONTROL over its value.
    Your expected output is an array of positive integers from 1 to n (inclusive).
    Your job is to write an algorithm that gets you from the input to the output.*/
    
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
