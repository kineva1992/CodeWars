using System;

namespace LeapYears
{
    class Program
    {
        public static bool isLeapYesr(int yers) => DateTime.IsLeapYear(yers);

        public static bool IsLeapYearVer2(int year)
        {
            if (year % 400 == 0) return true;1
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
        public static bool IsLeapYearVer3(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
