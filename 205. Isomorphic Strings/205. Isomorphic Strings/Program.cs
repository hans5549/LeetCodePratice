using System;
using System.Collections.Generic;
using System.Linq;

namespace _205._Isomorphic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "egg";
            string t = "add";
            bool o = IsIsomorphic(s, t);
        }

        public static bool IsIsomorphic(string s, string t)
        {
            List<int> a = GetCharIndexList(s);
            List<int> b = GetCharIndexList(t);

            if (Enumerable.SequenceEqual(a, b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<int> GetCharIndexList(string c)
        {
            List<int> indexList = new List<int>();
            List<char> chartemp = new List<char>();
            foreach (char t in c.ToCharArray())
            {
                int index = chartemp.IndexOf(t);
                if (index != -1)
                {
                    indexList.Add(index);
                }
                else
                {
                    chartemp.Add(t);
                    index = chartemp.IndexOf(t);
                    indexList.Add(index);
                }
            }

            return indexList;
        }
    }
}
