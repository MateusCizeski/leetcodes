using System.Xml;

namespace LeetCode.LeetCodes.Easy
{
    public class SearchInsertPositionClass
    {
        public int SearchInsertPosition(int[] nums, int target)
        {
            var inicio = 0;
            var fim = nums.Length - 1;
            
            while(inicio <= fim)
            {
                int meio = inicio + (fim - inicio) / 2;

                if (nums[meio] == target)
                {
                    return meio;
                }
                
                if (nums[meio] < target)
                {
                    inicio =  meio + 1;
                }else
                {
                    fim = meio - 1;
                }
            }

            return inicio;
        }
    }
}
