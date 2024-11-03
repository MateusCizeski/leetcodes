using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            char primeiroChar = textSplit[0][0];
            char ultimoChar = textSplit[textSplit.Length - 1][textSplit[textSplit.Length - 1].Length - 1];

            if(primeiroChar != ultimoChar)
            {
                return false;
            }

            for(int i = 0; i < textSplit.Length - 1; i++)
            {
                char ultimoCharPalavraAtual = textSplit[i][textSplit[i].Length - 1];
                char primeiroCharProximaPalavra = textSplit[i + 1][0];

                if(ultimoCharPalavraAtual != primeiroCharProximaPalavra)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
