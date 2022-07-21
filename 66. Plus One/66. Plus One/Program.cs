using System;

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
            digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            if (digits.Length == 1)
            {
                if (digits[0] >= 10)
                {
                    digits = new int[] { 1, 0 };
                }
            }
            else
            {
                for (int i = digits.Length - 1; i < 0; i++)
                {
                    if (digits[i] >= 10)
                    {
                        digits[i - 1] += 1;
                    }
                }
            }
            
            return digits;
        }
    }
}
