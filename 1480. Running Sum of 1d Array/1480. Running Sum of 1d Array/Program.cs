using System;

namespace _1480._Running_Sum_of_1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] sums = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sums[i] = sum;
            }

            return sums;
        }
    }
}
