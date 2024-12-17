using System;

namespace LeetCode.LeetCodes.Easy
{
    public class SqrtxClass
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;

            int low = 1, high = x, resposta = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                long quadrado = (long)mid * mid;

                if (quadrado == x)
                    return mid;

                if (quadrado < x)
                {
                    resposta = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return resposta;
        }
    }
}
