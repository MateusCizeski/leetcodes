﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetCodes.Easy
{
    public class ValidParenthesesClass
    {
        public bool ValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if(c == ')' && top != '(' ||
                       c == ']' && top != '[' ||
                       c == '}' && top != '{')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
