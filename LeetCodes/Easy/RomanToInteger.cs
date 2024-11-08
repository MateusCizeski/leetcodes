using System;
using System.Collections.Generic;

namespace LeetCode.LeetCodes.Easy
{
    public class RomanToIntegerClass
    {
        public int RomanToInteger(string s)
        {
            int total = 0;
            var romanoParaInteiro = new Dictionary<char, int> 
                                        {
                                            { 'I', 1 },
                                            { 'V', 5 },
                                            { 'X', 10 },
                                            { 'L', 50 },
                                            { 'C', 100 },
                                            { 'D', 500 },
                                            { 'M', 1000 }
                                        };


            for(int i = 0; i < s.Length; i++)
            {
                int current = romanoParaInteiro[s[i]];

                if(i + 1 < s.Length)
                {
                    int next = romanoParaInteiro[s[i + 1]];

                    if (current < next)
                    {
                        total -= current;

                    }
                    else
                    {
                        total += current;
                    }

                }
                else
                {
                    total += current;

                }
            }

            return total;
        }
    }
}
