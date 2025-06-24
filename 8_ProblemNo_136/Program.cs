using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_ProblemNo_136
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int output = solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
        }
    }

    public class Solution
    {
        public int SingleNumberParallelFor(int[] nums)
        {
            ConcurrentDictionary<int, int> keyValuePairsConcurrent = new ConcurrentDictionary<int, int>();
            IEnumerable<int> distintValues = nums.Distinct();
            Parallel.ForEach(distintValues, value =>
            {
                keyValuePairsConcurrent.TryAdd(value, 0);
            });

            Parallel.For(0, nums.Length, x =>
            {
                if (keyValuePairsConcurrent.Any(y => y.Key == nums[x]))
                {
                    KeyValuePair<int, int> item = keyValuePairsConcurrent.First(y => y.Key == nums[x]);
                    keyValuePairsConcurrent[nums[x]] = item.Value + 1;
                }
            });

            return keyValuePairsConcurrent.First(y => y.Value == 1).Key;
        }

        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int x = 0; x < nums.Length; x++)
            {
                if (keyValuePairs.ContainsKey(nums[x]))
                {   //// PREVIOUSLY USED CONTAINS / ANY() but not performance optimized used CONTAINSKEY which check for single element
                    KeyValuePair<int, int> item = keyValuePairs.First(y => y.Key == nums[x]);
                    keyValuePairs[nums[x]] = item.Value + 1;
                }
                else
                {
                    keyValuePairs.Add(nums[x], 1);
                }
            }

            return keyValuePairs.First(y => y.Value == 1).Key;
        }
    }
}
