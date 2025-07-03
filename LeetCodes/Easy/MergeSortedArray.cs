namespace LeetCode.LeetCodes.Easy
{
    public class MergeSortedArray
    {
        //complexidade temporal O(m + n) cada elemente do array é processado extamente uma vez
        //complexidade espacial O(1) o algoritmo não usa memória extra significativa
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
