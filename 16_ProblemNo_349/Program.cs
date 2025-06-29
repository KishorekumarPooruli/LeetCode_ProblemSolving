namespace _16_ProblemNo_349
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
        }
    }

    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> results = new List<int>();
            List<int> inputArray = nums2.ToList();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]) && !results.Any(y => y == nums1[i]))
                {
                    results.Add(nums1[i]);
                }
            }

            return results.ToArray();
        }
    }
}
