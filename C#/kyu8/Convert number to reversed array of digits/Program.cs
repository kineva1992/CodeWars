using System;


namespace Returning_Strings
{
    class Program
    {
        public static string Greet(string name)
        {
            if (name == " ")
            {
                return "hello";
            }
            else
            {
                return $"Hello,{name} how are you doing today?";
            }

        }

        public static string GreetVer2(string name)
        {
            return !string.IsNullOrEmpty(name) ? $"Hello, {name} how are you doing today?" : "Name is empty.";
}

       
        
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            Console.WriteLine(Remove_char("country"));
        }
    }
}
