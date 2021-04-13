using System;

namespace Mango
{
    class Program
    {

        public static int Mango(int quantity, int price) {

            var qty = quantity - Math.Floor((double)quantity / 3);

            return (int)qty * price;
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
