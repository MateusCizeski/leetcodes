using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetCodes.Easy
{
    public class MergeTwoSortedListsClass
    {
        public List<int> MergeTwoLists(List<int> list1, List<int> list2)
        {
            List<int> combinedList = list1.Concat(list2).ToList();

            combinedList.Sort();

            foreach (int i in combinedList) 
            {
                Console.WriteLine(i);
            }

            return combinedList;
        }
    }
}
