using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodes.Easy
{
    //Complexidade temporal O(n) cada string é visitado ao menos uma vez com os ponteiros.
    //Complexidade espacial O(1) é alocado apenas os ponteiros na memória.
    class IsPalindromeClass
    {
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                while (l < r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
               
                while (l < r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }

                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                {
                    return false;
                }

                l++;
                r--;
            }

            return true;
        }
    }
}
