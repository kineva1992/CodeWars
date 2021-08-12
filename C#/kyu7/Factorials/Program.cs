using System;
using NUnit.Framework;

namespace Factorials
{
    class Program
    {

        public static int factorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

            
        }


        static void Main(string[] args)
        {
            Assert.AreEqual(1, Program.factorial(0));
            Assert.AreEqual(1, Program.factorial(1));
            Assert.AreEqual(2, Program.factorial(2));
            Assert.AreEqual(6, Program.factorial(3));
            Assert.AreEqual(24, Program.factorial(4));
            Assert.AreEqual(120, Program.factorial(5));
        }
    }
}
