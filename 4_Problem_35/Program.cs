namespace _4_Problem_35
{
    using System.Linq;

    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
        ////Input: nums = [1, 3, 5, 6], target = 5
        ////Output: 2

        ////Input: nums = [1, 3, 5, 6], target = 2
        ////Output: 1

        ////Input: nums = [1, 3, 5, 6], target = 7
        ////Output: 4

        ////Input: nums = [1, 3, 5, 6], target = 8
        ////Output: 4

        ////Input: nums = [1001], target = 5
        ////Output: 0

        ////Input: nums = [-1, 3, 5, 6], target = 0
        ////Output: 1

        ////Input: nums = [1], target = 2
        ////Output: 1

            int output = solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);

        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int targetIndex = 0;
            bool isTargentFound = false;
            int iterationCount = 0; //// used to Identify target is avaiable directly or checking previous valies in array
            do
            {
                isTargentFound = nums.Any(y => y == target); //// used LINQ Method
                if (isTargentFound)
                {
                    targetIndex = Array.IndexOf(nums, target);
                }
                else
                {
                    target = target - 1;
                    iterationCount++;
                }
            } while (iterationCount <= nums.Length && isTargentFound != true);

            return iterationCount > 0 && isTargentFound ? targetIndex + 1 : targetIndex;
        }
    }
}
