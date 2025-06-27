namespace _10_ProblemNo_217
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate-ii/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ContainDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        }
    }

    public class Solution
    {
        public bool ContainDuplicate(int[] nums)
        {
            bool result = true;
            int[] distinct = nums.Distinct().ToArray();
            if (distinct.Length == nums.Length)
            {
                result = false;
            }

            return result;
        }
    }
}
