using System;

namespace Swapper
{
    /*
    I would like to be able to pass an array with two elements to my swapValues function to swap the values. However it appears that the values aren't changing.

Can you figure out what's wrong here?
    */
    class Program
    {
        public object[] Arguments { get; private set; }

        public Program(object[] args)
        {
          Arguments = args;
        }

        public void SwapValues() => Array.Reverse(Arguments);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
