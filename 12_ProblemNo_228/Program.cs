namespace _12_ProblemNo_228
{
    /// <summary>
    /// https://leetcode.com/problems/summary-ranges/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.SummaryRanges(new int[] { -2147483648, -2147483647, 2147483647 });
        }
    }

    public class Solution
    {
        public List<string> SummaryRanges(int[] nums)
        {
            Dictionary<int, List<int>> keyValuesOutput = new Dictionary<int, List<int>>();
            int previousValue = -999;
            int groupValue = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (previousValue != -999)
                {
                    int expectedValue = previousValue + 1;
                    if (nums[i] == expectedValue)
                    {
                        var previousDictInstance = keyValuesOutput.First(y => y.Key == groupValue);
                        previousDictInstance.Value.Add(nums[i]);
                        previousValue = nums[i];
                        groupValue = previousDictInstance.Key;
                    }
                    else
                    {
                        previousValue = nums[i];
                        groupValue = nums[i];
                        keyValuesOutput.Add(nums[i], new List<int>());
                    }
                }
                else
                {
                    previousValue = nums[i];
                    groupValue = nums[i];
                    keyValuesOutput.Add(nums[i], new List<int>());
                }

            }

            List<string> output = new List<string>();
            foreach(var result in keyValuesOutput)
            {
                if (result.Value.Any())
                {
                    output.Add($"{result.Key}->{result.Value.Last()}");
                }
                else
                {
                    output.Add($"{result.Key}");
                }
            }

            return output;
        }
    }
}
