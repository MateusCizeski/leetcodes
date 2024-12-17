using System;

namespace LeetCode.LeetCodes.Easy
{
    public class SqrtxClass
    {
        public int MySqrt(int x)
        {
            double low = 0;
            double precisao = 0.00001;
            double mid = 0;

            while ((x - low) > precisao)
            {
                mid = (low + x) / 2;
                double quadrado = mid * mid;

                if (Math.Abs(quadrado - x) <= precisao)
                    return (int)mid;

                if (quadrado < x)
                    low = mid; 
                else
                    x = (int)mid;
            }

            return (int)mid;
        }
    }
}
