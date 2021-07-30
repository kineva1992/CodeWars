using System;

namespace Substituting_Variables_Into_Strings
{
    class Program
    {
        public static string Solution(int value)
        {
            string result = value.ToString().PadLeft(5, '0');
            return $"Value is {result}";
        }

        public static string SolutionVer2(int value)
        {
            return $"Value is {value:D5}";
        }

        public static string SolutionVer3(int value)
        {
            var result = value.ToString();

            while (result.Length > 5) {
                result = "0" + result;
            }
            return $"Value is {result}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution(55555));
        }
    }
}
