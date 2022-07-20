using System.Linq;

namespace _58._Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = LengthOfLastWord("   fly me   to   the moon  ");
        }

        public static int LengthOfLastWord(string s)
        {
            string[] stringArray = s.Replace(@"\s+", " ").Split(" ").Where(x => x.Length > 0).ToArray();

            return stringArray[stringArray.Length - 1].Length;
        }
    }
}
