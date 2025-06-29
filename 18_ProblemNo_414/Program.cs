namespace _18_ProblemNo_414
{
    /// <summary>
    /// https://leetcode.com/problems/third-maximum-number/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ThirdMax(new int[] { 3,2,1});
        }
    }

    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            int output = 0;          
            var distinctInput = nums.Distinct().OrderByDescending(c=>c).ToArray();
            int[] inputArray = new int[distinctInput.Length];
            Array.Copy(distinctInput, inputArray, distinctInput.Length);

            
            int maxLength = inputArray.Length;
            if(maxLength >= 3)
            {
                output = inputArray[3 - 1];
            }
            else
            {
                output = inputArray.Max();
            }

            return output;
        }
    }
}
