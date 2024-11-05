using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodes.Easy
{
    public class PalindromeNumberClass
    {
        public bool PalindromeNumber(int number)
        {
            if(number < 0)
            {
                return false;
            }

            string numberText = number.ToString();
            string reversedText = new string(numberText.Reverse().ToArray());
            int reverseNumber = int.Parse(reversedText);

            return number == reverseNumber;
        }

        public bool PalindromeNumber2(int number)
        {
            if (number < 0 || (number % 10 == 0 && number != 0))
                return false;

            int reversedHalf = 0;
            while (number > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + number % 10;
                number /= 10;
            }

            return number == reversedHalf || number == reversedHalf / 10;
        }

        public bool PalindromeNumber3(int number)
        {
            if (number < 0) return false;

            int divisor = 1;
            while (number / divisor >= 10)
            {
                divisor *= 10;
            }

            while (number != 0)
            {
                int leading = number / divisor;
                int trailing = number % 10;

                if (leading != trailing)
                    return false;

                number = (number % divisor) / 10;
                divisor /= 100;
            }

            return true;
        }
    }
}
