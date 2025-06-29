namespace _19_ProblemNo_448
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindDisappearedNumbers(new int[] { 2, 2 });
        }
    }

    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> missingNumbers = new List<int>();
            int endIndex = nums.Length;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!nums.Contains(i)) //// CONTAINS is faster than ANY()
                {
                    missingNumbers.Add(i);
                }                
            }

            return missingNumbers;
        }
    }
}
