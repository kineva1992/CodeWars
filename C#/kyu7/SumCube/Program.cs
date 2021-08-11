using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SumCube
{
    /*
     Write a function that takes a positive integer n, sums all the cubed values from 1 to n, and returns that sum.

     Assume that the input n will always be a positive integer.

     Examples:

     sumCubes(2) 
    
     9 sum of the cubes of 1 and 2 is 1 + 8
     */

    class Program
    {
        public static long SumCubes(int n) => (long)Math.Pow(n * (n + 1) / 2, 2);


       
        static void Main(string[] args)
        {
            Assert.AreEqual(1, SumCubes(1));
            Assert.AreEqual(9, SumCubes(2));
            Assert.AreEqual(36, SumCubes(3));
            Assert.AreEqual(100, SumCubes(4));
            Assert.AreEqual(3025, SumCubes(10));
            Assert.AreEqual(58155876, SumCubes(123));
        }
    }
}
