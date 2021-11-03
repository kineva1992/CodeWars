using System;

namespace Filter_the_number
{
    class Program
    {
        public static int FilterString(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsLetter(s[i]))
                    result += s[i];
            }
            return Convert.ToInt32(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FilterString("aa1bb2cc3dd"));
        }
    }
}
