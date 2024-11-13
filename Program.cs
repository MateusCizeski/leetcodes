using LeetCode.LeetCodes.Easy;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunTwoSumExample();
            //RunCircularSentence();
            //RotateString();
            //PalindromeNumber();
            //LongestCommonPrefix();
            //RomanToInteger();
            //ValidParentheses();
            //MergeTwoSortedLists();
            //RemoveDuplicatesSortedArray();

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

        #region LongestCommonPrefix
        static void LongestCommonPrefix()
        {
            LongestCommonPrefixClass longestCommonPrefix = new LongestCommonPrefixClass();
            string[] strs = new string[] { "abrir", "abastecer", "abrigo" };

            string result = longestCommonPrefix.LongestCommonPrefix(strs);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region RomanToInteger
        static void RomanToInteger()
        {
            RomanToIntegerClass romanToInteger = new RomanToIntegerClass();
            string s = "IV";

            int result = romanToInteger.RomanToInteger(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region ValidParentheses
        static void ValidParentheses()
        {
            ValidParenthesesClass validParentheses = new ValidParenthesesClass();
            string s = "([]{})";

            bool result = validParentheses.ValidParentheses(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region MergeTwoSortedLists
        static void MergeTwoSortedLists()
        {
            MergeTwoSortedListsClass mergeTwoSortedLists = new MergeTwoSortedListsClass();
            List<int> list1 = new List<int> { 1, 2, 4 };
            List<int> list2 = new List<int> { 1, 3, 4 };

            List<int> result = mergeTwoSortedLists.MergeTwoLists(list1, list2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region RemoveDuplicatesSortedArray
        static void RemoveDuplicatesSortedArray()
        {
            RemoveDuplicatesSortedArrayClass removeDuplicatesSortedArray = new RemoveDuplicatesSortedArrayClass();
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            int result = removeDuplicatesSortedArray.RemoveDuplicatesSortedArray(nums);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region RemoveElement
        static void RemoveElement()
        {
            RemoveElementClass removeElement = new RemoveElementClass();
            int[] nums = { 3, 2, 2, 3 };

            int result = removeElement.RemoveElement(nums);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
    }
}
