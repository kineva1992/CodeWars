using System;

namespace The_Wide_Mouthed_frog_
{
    
    class Program
    {
        public static string MouthSize(string animal)
        {
            var toLowerString = animal.ToLower();

            if (toLowerString == "alligator")
            {
                return "small";
            }
            else return "wide";

        }


        public static string MouthSizeVer2(string animal) {
            return (animal.ToLower() == "alligator") ? "small" : "wide";
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
