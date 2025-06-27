namespace _9_ProblemNo_169
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/submissions/1678084949/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MajorityElement(new int[] { 3, 2, 3 });
        }
    }

    public class  Solution
    {
        public int MajorityElement(int[] nums)
        {
            int highestNumberInArray = 0;
            int highestNumberCount = 0;
            int[] distints = nums.Distinct().ToArray();
            for (int i = 0; i < distints.Length; i++)
            {
                int instanceCount = nums.Count(y => y == distints[i]);
                if (instanceCount > highestNumberCount)
                {
                    highestNumberInArray = distints[i];
                    highestNumberCount = instanceCount;
                }
            }

            return highestNumberInArray;
        }
    }
}
