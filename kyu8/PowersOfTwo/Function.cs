using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PowersOfTwo
{
    class Function
    {
        public static BigInteger[] PowersOfTwo(int n)
        {

        BigInteger[] result = new BigInteger[n + 1]; 
             
        for (int i = 0; i < result.Length; i++)
                {
                result[i] = (BigInteger)Math.Pow(2,i);
                    
                }

            return result;
        }

    }
}
