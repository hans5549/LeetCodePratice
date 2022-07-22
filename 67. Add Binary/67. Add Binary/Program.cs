using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _67._Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1110110101";
            string b = "1110111011";
            string binary = AddBinary(a, b);
        }

        public static string AddBinary(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
            {
                return b;
            }
            else if (string.IsNullOrEmpty(b))
            {
                return a;
            }
            else
            {
                int i = a.Length - 1;
                int j = b.Length - 1;
            }
        }
    }
}
