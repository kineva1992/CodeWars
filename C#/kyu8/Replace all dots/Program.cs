using System;
using System.Text.RegularExpressions;

namespace Replace_all_dots
{
    class Program
    {
        /*
        The code provided is supposed replace all the dots . in the specified String str with dashes -
        But it's not working properly.

        Task
        Fix the bug so we can all go home early.

        Notes
        String str will never be null.
         */
        public static string ReplaceDots(string str)
        {
            return new Regex("\\.").Replace(str, "-");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReplaceDots("one.two.three"));
            Console.ReadKey();
        }
    }
}
