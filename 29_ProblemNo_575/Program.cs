namespace _29_ProblemNo_575
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-candies/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.DistributeCandies(new int[] { 6, 6, 6, 6 });
        }
    }

    public class Solution
    {
        public int DistributeCandies(int[] candyType)
        {
            int advisedNoToEat = candyType.Length / 2;
            int[] uniqueCandies = candyType.Distinct().ToArray();

            if (uniqueCandies.Length >= advisedNoToEat)
            {
                return advisedNoToEat;
            }

            return uniqueCandies.Length;
        }
    }
}
