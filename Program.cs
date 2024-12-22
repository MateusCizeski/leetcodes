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
            //RemoveElement();
            //FirstOccurrenceString();
            //SearchInsertPosition();
            //LengthLastWord();
            //PlusOne();
            //AddBinary();
            //Sqrt();
            RemoveDuplicateSortedList();

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
            int val = 3;

            int result = removeElement.RemoveElement(nums, val);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region FirstOccurrenceString
        static void FirstOccurrenceString()
        {
            FirstOccurrenceStringClass firstOccurrenceString = new FirstOccurrenceStringClass();
            string haystack = "sadbutsad";
            string needle = "sad";

            int result = firstOccurrenceString.FirstOccurrenceString(haystack, needle);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region SearchInsertPosition
        static void SearchInsertPosition()
        {
            SearchInsertPositionClass searchInsertPositionClass = new SearchInsertPositionClass();
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;

            int result = searchInsertPositionClass.SearchInsertPosition(nums, target);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region LengthLastWord
        static void LengthLastWord()
        {
            LengthLastWordClass LengthLastWordClass = new LengthLastWordClass();
            string s = "luffy is still joyboy";

            int result = LengthLastWordClass.LengthLastWord(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region PlusOne
        static void PlusOne()
        {
            PlusOneClass plusOneClass = new PlusOneClass();
            int[] nums = { 4, 3, 2, 1 };

            int[] result = plusOneClass.PlusOne(nums);

            Console.WriteLine("Resultado: " + string.Join(",", result));
            Console.ReadLine();
        }
        #endregion

        #region AddBinary
        static void AddBinary()
        {
            AddBinaryClass binaryClass = new AddBinaryClass();
            string a = "1010";
            string b = "1011";

            string result = binaryClass.AddBinary(a, b);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region SqrtX
        static void Sqrt()
        {
            SqrtxClass sqrtxClass = new SqrtxClass();
            int x = 8;

            int result = sqrtxClass.MySqrt(x);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region ClimbStairs
        static void ClimbStairs()
        {
            ClimbStairsClass climbStairs = new ClimbStairsClass();
            int x = 2;

            int result = climbStairs.ClimbStairs(x);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region RemoveDuplicateSortedList
        static void RemoveDuplicateSortedList()
        {
            RemoveDuplicateSortedList removeDuplicateSortedList = new RemoveDuplicateSortedList();
            List<int> head = new List<int> { 1, 1, 2, 3, 3 };

            List<int> result = removeDuplicateSortedList.DeleteDuplicates(head);

            Console.WriteLine("Resultado: " + string.Join(", ", result));
            Console.ReadLine();
        }
        #endregion
    }
}
