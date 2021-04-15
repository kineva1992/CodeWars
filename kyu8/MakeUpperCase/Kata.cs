using System;
using System.Collections.Generic;
using System.Text;

namespace MakeUpperCase
{
    class Kata
    {
        /*
        Write a function which converts the input string to uppercase.
        */

        public static string MakeUpperCase(string str) {

            string upeerCaseText = str.ToUpper();

            Console.WriteLine(upeerCaseText);
            return upeerCaseText;
        }
        
        /*
        Kids drink toddy.
    Teens drink coke.
    Young adults drink beer.
    Adults drink whisky.
    Make a function that receive age, and return what they drink.

    Rules:

    Children under 14 old.
    Teens under 18 old.
    Young under 21 old.
    Adults have 21 or more.
    Examples: (Input --> Output)

    13 --> "drink toddy"
    17 --> "drink coke"
    18 --> "drink beer"
    20 --> "drink beer"
    30 --> "drink whisky"
        */

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
        
        /*Collect| This code does not execute properly. Try to figure out why.*/
        

        public static int multiply(int a, int b) {

           int sum = a * b;
            return sum;
        }
        
        /*
        You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

    Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples:

    Kata.Likes(new string[0]) => "no one likes this"
    Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
    Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
    Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
    Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
        */

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

        /*The Story:
    Bob is working as a bus driver. However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he will be able to fit all the passengers.

    Task Overview:
    You have to write a function that accepts three parameters:

    cap is the amount of people the bus can hold excluding the driver.
    on is the number of people on the bus excluding the driver.
    wait is the number of people waiting to get on to the bus excluding the driver.
    If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.*/

        public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);


    }
}
