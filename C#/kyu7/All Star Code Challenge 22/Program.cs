using System;

namespace All_Star_Code_Challenge_22
{
    class Program
    {
       

    public static class Kata
    {
        public static string ToTime(int seconds)
        {
                var hour = Math.Floor((decimal)seconds/3600);
                var minutes = Math.Floor((seconds - (hour * 3600)) / 60);


            return $"{hour} hour(s) and {minutes} minute(s)";
        }
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
