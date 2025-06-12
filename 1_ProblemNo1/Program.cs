namespace _1_ProblemNo1
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] output = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int totalIteration = nums.Length - 1; //// Counting the No.Of Times to Compare with start Value
            for (int i = 0; i <= totalIteration; i++)
            {
                int startNoOfLoop = nums[i];
                int indexOfStartingNo = Array.IndexOf(nums, startNoOfLoop);
                int numOfIterationTimesAfterStartingNo = totalIteration - indexOfStartingNo;

                for (int y = 1; y <= numOfIterationTimesAfterStartingNo; y++)
                {
                    if (startNoOfLoop + nums[indexOfStartingNo + y] == target)
                    {
                        return new int[] { indexOfStartingNo, (indexOfStartingNo + y) };
                    }
                }

                numOfIterationTimesAfterStartingNo--;
            }

            return new int[] { };
        }
    }
}
