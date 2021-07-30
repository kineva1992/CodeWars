using System;

namespace Remove_First_and_Last_Character
{
    class Program
    {
        public static string Remove_char(string s)
        {

            string[] arrStr = s.Split(' ');

            string res = "";

            foreach (var a in arrStr)
            {

                res += a.Substring(1, a.Length - 2);
            }

            return res;

        }

        public static string Remove_charVer2(string s)
        {
            return s.Substring(1, (s.Length - 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
