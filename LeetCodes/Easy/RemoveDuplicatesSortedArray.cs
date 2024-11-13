using System.Collections.Generic;

namespace LeetCode.LeetCodes.Easy
{
    public class RemoveDuplicatesSortedArrayClass
    {
        public int RemoveDuplicatesSortedArray(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
