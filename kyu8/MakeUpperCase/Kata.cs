using System;
using System.Collections.Generic;
using System.Text;

namespace MakeUpperCase
{
    class Kata
    {

        public static string MakeUpperCase(string str) {

            string upeerCaseText = str.ToUpper();

            Console.WriteLine(upeerCaseText);
            return upeerCaseText;
        }

        public static string PeopleWithAgeDrink(int old)
        {

            string[] whoDrink = { "drink toddy", "drink coke", "drink beer", "drink whisky" };

            if (old < 14) {
                return whoDrink[0];
            }

            if (old < 18) {
                return whoDrink[1];
            }
            if (old < 21) {
                return whoDrink[2];
            }

            Console.WriteLine(whoDrink);

            return whoDrink[3];
  }

        public static int multiply(int a, int b) {

           int sum = a * b;
            return sum;
        }

        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }

            else if (name.Length == 1) {
                return $"{name[0]} likes this";
            }

            else if (name.Length == 2) {
                return $"{name[0]} and {name[1]} like this";
            }

            else if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }

            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }


        public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);


    }
}
