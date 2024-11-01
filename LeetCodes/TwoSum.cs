using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (map.ContainsKey(diff))
                {
                    return new int[] { map[diff], i };
                }

                map[nums[i]] = i;
            }

            throw new ArgumentException("Nenhuma solução encontrada, embora o problema garanta uma.");
        }
    }
}
