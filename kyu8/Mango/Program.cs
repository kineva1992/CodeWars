using System;

namespace Mango
{
    class Program
    {

        public static int Mango(int quantity, int price) {

            var qty = quantity - Math.Floor((double)quantity / 3);

            return (int)qty * price;
        
        }

        public static int Paperwork(int n, int m)
        {
            int sum = n * m;

            if (n < 0 && m < 0)
            {
                return 0;
            }

            else return sum;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
