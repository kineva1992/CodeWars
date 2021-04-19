using System;

namespace Credit_Card_Mask
{
    class Program
    {
        public static string Maskify(string cc) {
            
            string addString;
            string fourEndNumber;

            if (cc.Length < 4) return cc;

            
            fourEndNumber = cc.Substring(cc.Length - 4);
            addString = "";
            for (int i = 0; i < cc.Length - 4; i++) {
                addString += "#";
            }
            return addString + fourEndNumber;
        }

        public static string MaskifyVer2(string cc)
        {
            int len = cc.Length;
            if (len <= 4) {
                return cc;
            }

            return cc.Substring(len - 4).PadLeft(len, "#")
            
        }


        static void Main(string[] args)
        {
            string str = "4556364607935616";


            Console.WriteLine(Maskify(str));
        }
    }
}
