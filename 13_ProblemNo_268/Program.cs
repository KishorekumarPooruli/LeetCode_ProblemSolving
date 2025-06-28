namespace _13_ProblemNo_268
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        }
    }

    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int startNum = 0;
            int endNum = nums.Length;
            int missingNumber = -1;
            Array.Sort(nums);
            for (int i = startNum; i <= nums.Length; i++)
            {
                if (i == endNum || nums[i] != i)
                {
                    missingNumber = i;
                    break;
                }
            }

            return missingNumber;
        }
    }
}
