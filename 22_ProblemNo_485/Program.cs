namespace _22_ProblemNo_485
{
    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 });
        }
    }

    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            List<ValueTuple<int, int>> tupleCollection = new List<ValueTuple<int, int>>();
            for(int i = 0; i < nums.Length; i++)
            {
                int previousIndex = i - 1;
                if (previousIndex >=0 && previousIndex < nums.Length && nums[previousIndex] == 1 && nums[i] == 1)
                {
                    var existingInstance = tupleCollection.Last();
                    existingInstance.Item2 = existingInstance.Item2 + 1;
                    tupleCollection[tupleCollection.Count - 1] = existingInstance;
                }
                else
                {
                    if (nums[i] == 1)
                    {
                        tupleCollection.Add(new ValueTuple<int, int>(1, 1));
                    }
                }                
            }

            int maxItem = 0;
            foreach (var item in tupleCollection)
            {
                if (item.Item2 > maxItem)
                {
                    maxItem = item.Item2;
                }
            }

            return maxItem;
        }
    }
}
