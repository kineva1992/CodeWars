using System;

namespace DutyFree
{
    class Program
    {
        public static int DutyFree(int normPrice, int Discont, int hol) {


            double totalSumm = hol * 100 / (normPrice * Discont);

            Console.WriteLine(totalSumm);

            return (int)totalSumm;
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DutyFree(12, 50, 1000);

            Console.ReadKey();
        }
    }
}
