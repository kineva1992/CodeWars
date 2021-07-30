using System;

namespace The_Wide_Mouthed_frog_
{

    /*
     The wide mouth frog is particularly interested in the eating habits of other creatures.
    He just can't stop asking the creatures he encounters what they like to eat. But then he meet the alligator who just LOVES to eat wide-mouthed frogs!
    When he meets the alligator, it then makes a tiny mouth.
    Your goal in this kata is to create complete the mouth_size method this method take one argument animal which corresponds to the animal encountered by frog. If this one is an alligator (case insensitive) return small otherwise return wide.
     */

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
