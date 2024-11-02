using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodes.Easy
{
    public class CircularSentenceClass
    {

        public bool CircularSentence(string text)
        {
            string[] textSplit = text.Split(' ');

            foreach (string s in textSplit)
            {
                Console.WriteLine(s);
            }

            return false;
        }
    }
}
