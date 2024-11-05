using LeetCode.LeetCodes.Easy;
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
            //RunTwoSumExample();
            //RunCircularSentence();
            //RotateString();
            PalindromeNumber();
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

        #region CircularSentence
        static void RunCircularSentence()
        {
            CircularSentenceClass cirucularSentence = new CircularSentenceClass();
            string text = "leetcode exercises sound delightful";

            bool result = cirucularSentence.CircularSentence(text);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region RotateString
        static void RotateString()
        {
            RotateStringClass rotateString = new RotateStringClass();
            string text = "abcde";
            string goal = "cdeab";

            bool result = rotateString.RotateString(text, goal);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region PalindromeNumber
        static void PalindromeNumber()
        {
            PalindromeNumberClass palindromeNumber = new PalindromeNumberClass();
            int number = 123;

            bool result = palindromeNumber.PalindromeNumber(number);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
    }
}
