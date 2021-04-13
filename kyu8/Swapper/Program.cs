using System;

namespace Swapper
{
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
