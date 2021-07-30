using System;
using System.Collections.Generic;
using System.Linq;

namespace Digitize
{
    class Program
    {
        public static int[] digitize(int n) {
            if (n == 0) {
                return new int[1] { 0 };
            }

            List<int> digit = new List<int>();


            for (; n != 0; n /= 10) {
                digit.Add(n % 10);
            }

            int[] array = digit.ToArray();

            Array.Reverse(array);
            return array;
        }

        public static int[] digitizeVer2(int n)
        {
            return n.ToString().Select(ch => Int32.Parse(ch.ToString())).ToArray();
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
