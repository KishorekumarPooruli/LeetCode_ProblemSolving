namespace _30_ProblemNo_594
{
    /// <summary>
    /// https://leetcode.com/problems/longest-harmonious-subsequence/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindLHS(new int[] { 1, 1, 1, 1 });
            //// TIME COMPLEXITY :  O(N^2)
        }
    }

    public class Solution() 
    {
        public int FindLHS(int[] nums)
        {
            List<int> harmoniousSequence = new List<int>();
            int[] unique = nums.Distinct().ToArray();
            Dictionary<int, int> uniquePairs = new Dictionary<int, int>();
            for ( int i = 0; i < unique.Length; i++)
            {
                uniquePairs.Add(unique[i], nums.Count(y => y == unique[i]));
            }

            int maxTotal = 0;
            foreach(var item in uniquePairs)
            {
                int kItemPlusOne = item.Key + 1;
                if (uniquePairs.ContainsKey(kItemPlusOne))
                {
                    int total = item.Value + uniquePairs[kItemPlusOne];
                    if (total > maxTotal) 
                    {
                        maxTotal = total;
                    }
                }

            }

            return maxTotal;
        }
    }
}
