using System;

namespace _35._Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int index = SearchInsert(nums, 5);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}
