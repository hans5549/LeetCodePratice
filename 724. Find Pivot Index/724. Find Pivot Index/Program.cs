using System;
using System.Linq;

namespace _724._Find_Pivot_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            int index = PivotIndex(nums);
    }

        public static int PivotIndex(int[] nums)
        {
            int sumA = 0;
            int sumB = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                sumB -= nums[i];
                if (sumA == sumB) return i;
                else sumA += nums[i];
            }

            return -1;
        }
    }
}
