using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAPileOfCubes
{
    public class Kata
    {
        static long cube(long a)
        {
            return a * a * a;
        }
        static long counterofcubes(long m)
        {
            long count;
            count = 0;
            long n = 1;
            while (m > 0)
            {
                m = m - cube(n);
                n++;
                count++;
            }
            if (m == 0)
            {
                return count;
            }
            else
            {
                return -1;
            }
        }



        public static long findNb(long m)
        {
            return counterofcubes(m);
        }
    }
}
