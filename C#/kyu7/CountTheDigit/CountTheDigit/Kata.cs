using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDigit
{
    internal class Kata
    {
        public static int NbDig(int n, int d)
        {
            int result = 0;
            
            for (int i = 0; i <= n; i++)
            {
                int square = i * i;
                result += square.ToString().Count(x => x == d.ToString()[0]);
            }

            return result;
        }
    }
}
