namespace _2_ProblemNo_26
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int output = solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> uniqueElements = new List<int>();
            int length = nums.Length; //// gets the I/P Lenght 
            for (int i = 0; i < nums.Length; i++)
            {
                if (!uniqueElements.Any(y => y == nums[i]))
                {
                    uniqueElements.Add(nums[i]);
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                //// COPY LIST VALUES TO SOURCE ARRAY with Same Length
                if (j < uniqueElements.Count)
                {

                    nums[j] = uniqueElements[j];
                }
                else
                {
                    nums[j] = 0;
                }
            }

            return uniqueElements.Count; //// returns Unique Element Count

        }
    }
}
