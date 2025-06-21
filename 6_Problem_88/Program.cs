namespace _6_Problem_88
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.Merge(new int[] { 1, 0 }, 1, new int[] { 2 }, 1);
            //// 1,2,3,0,0,0    3      2,5,6    3       O/P  : 1,2,2,3,5,6    P
            //// 0              0       1       1       O/P   : 1             P
            //// 1,0            1        2      1       O/P     : [1,2]   
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> finalOutput = new List<int>();
            int indexOfLastElement = -1;
            for (int x = nums1.Length - 1 ; x < nums1.Length && x >= 0; x--)
            {
                if (nums1[x] != 0) 
                {
                    indexOfLastElement = x;
                    break;
                }
            }

            int[] final = new int[ m + n];
            for(int i = 0; i < nums1.Length; i++)
            {
                if(indexOfLastElement >= 0 && i <= indexOfLastElement)
                {
                    finalOutput.Add(nums1[i]);
                }
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                finalOutput.Add(nums2[j]);
            }

            int[] finalArray = finalOutput.ToArray();
            Array.Sort(finalArray);
            Array.Copy(finalArray, nums1, finalArray.Length);
        }
    }
}
 