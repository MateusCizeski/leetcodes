using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunTwoSumExample();
        }

        #region TwoSum
        static void RunTwoSumExample()
        {
            var twoSum = new TwoSumClass();

            int[] nums = { 2, 7, 11, 15 };
            int target = 26;
            int[] result = twoSum.TwoSum(nums, target);

            Console.WriteLine($"Índices encontrados: {result[0]}, {result[1]}");
            Console.ReadLine();
        }
        #endregion
    }
}
