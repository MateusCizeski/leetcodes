using System.Collections.Generic;

namespace LeetCode.LeetCodes.Easy
{
    class LetterCombinationsSolver
    {
        private static readonly Dictionary<char, string> digitToChar = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            if (string.IsNullOrEmpty(digits))
                return result;

            void Backtrack(int index, string current)
            {
                if (index == digits.Length)
                {
                    result.Add(current);
                    return;
                }

                string possibleLetters = digitToChar[digits[index]];

                foreach (char ch in possibleLetters)
                {
                    Backtrack(index + 1, current + ch);
                }
            }

            Backtrack(0, "");

            return result;
        }
    }
}
