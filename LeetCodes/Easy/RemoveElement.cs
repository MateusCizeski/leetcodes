﻿using System;
using System.Xml.Linq;

namespace LeetCode.LeetCodes.Easy
{
    public class RemoveElementClass
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int k = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
