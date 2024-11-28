using System.Linq;

namespace LeetCode.LeetCodes.Easy
{
    public class LengthLastWordClass
    {
        public int LengthLastWord(string s)
        {
            var sSplit = s.Trim().Split(' ');
            var lastWord = sSplit.Length - 1;

            var word = sSplit[lastWord];
            var count = word.Length;
           
            return count;
        }

        //Outra solução
        //public int LengthLastWord(string s)
        //{
        //    int length = 0;
        //    int i = s.Length - 1;

        //    while (i >= 0 && s[i] == ' ')
        //        i--;

        //    while (i >= 0 && s[i] != ' ')
        //    {
        //        length++;
        //        i--;
        //    }

        //    return length;
        //}
    }
}
