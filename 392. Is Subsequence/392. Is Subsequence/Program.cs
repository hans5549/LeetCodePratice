using System;
using System.Collections.Generic;
using System.Linq;

namespace _392._Is_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cc";
            string t = "bc";
            bool o = IsSubsequence(s, t);
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }

            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            int sIndex = 0;
            for (int tIndex = 0; tIndex < t.Length; ++tIndex)
            {
                if (sArray[sIndex] == tArray[tIndex])
                {
                    ++sIndex;
                }

                if (sIndex == s.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
