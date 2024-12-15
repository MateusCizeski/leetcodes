using System.Linq;
using System.Text;

namespace LeetCode.LeetCodes.Easy
{
    public class AddBinaryClass
    {
        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            StringBuilder result = new StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int bitA = i >= 0 ? a[i] - '0' : 0;
                int bitB = j >= 0 ? b[j] - '0' : 0;

                int sum = bitA + bitB + carry;
                result.Append(sum % 2);
                carry = sum / 2;

                i--;
                j--;
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
