using System;
using System.Collections.Generic;

namespace _66._Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 9 };
            int[] a = PlusOne(digits);
        }

        public static int[] PlusOne(int[] digits)
        {
            List<int> digitslist = new List<int>();
            digitslist.AddRange(digits);
            digitslist[digits.Length - 1] = digitslist[digits.Length - 1] + 1;

            for (int i = digitslist.Count - 1; i > -1; i--)
            {
                if (digitslist[i] >= 10)
                {
                    digitslist[i] = 0;
                    if (i == 0)
                    {
                        digitslist.Insert(0, 1);
                    }
                    else
                    {
                        digitslist[i - 1] += 1;
                    }
                }
            }

            return digitslist.ToArray();
        }
    }
}
