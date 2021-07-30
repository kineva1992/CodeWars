using System;
using System.Collections.Generic;
using System.Text;

namespace ReverceString
{
    class Kata
    {
        public static string Solotion(string str) {

            var newStr = "";
            for (var i = str.Length - 1; i >= 0; i--) {
                newStr += str[i];
            }

            Console.WriteLine(newStr);

            return newStr;
        }
    }
}
