namespace _24_ProblemNo_496
{
    /// <summary>
    /// https://leetcode.com/problems/next-greater-element-i/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.NextGreaterElement(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 });
        }
    }

    public class Solution()
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {   
                if (nums2.Contains(nums1[i]))
                {
                    int indexOfValue = Array.IndexOf(nums2, nums1[i]);
                    int nextValue = indexOfValue + 1; 


                    if (nextValue < nums2.Length)
                    {
                        IEnumerable<int> afterIndexValues = nums2.Skip(nextValue);

                        if (afterIndexValues.Any(y => y > nums1[i]))
                        {
                            var instance = afterIndexValues.First(y => y > nums1[i]);
                            result.Add(instance);
                        }
                        else
                        {
                            result.Add(-1);
                        }
                    }
                    else
                    {
                        result.Add(-1);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
