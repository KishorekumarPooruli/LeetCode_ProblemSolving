namespace _17_ProblemNo_350
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2 });
        }
    }

    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> inputArray = nums2.ToList();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    if (!keyValuePairs.ContainsKey(nums1[i]))
                    {
                        keyValuePairs.Add(nums1[i], 1);
                    }
                    else
                    {
                        if (keyValuePairs.ContainsKey(nums1[i]))
                        {
                            var instance = keyValuePairs.First(y => y.Key == nums1[i]);
                            keyValuePairs[nums1[i]] = instance.Value + 1;
                        }
                    }
                }
            }

            foreach(var i in nums2.Where(y=> keyValuePairs.ContainsKey(y)).Distinct())
            {
                var count = nums2.Count(y => y == i);
                var instance = keyValuePairs.First(y => y.Key == i);
                if(count <= instance.Value && instance.Value != count)
                {
                    keyValuePairs[i] = count;
                }

            }

            List<int> results = new List<int>();
            foreach(var item in keyValuePairs)
            {
                for (int i = 0 ; i < item.Value; i++)
                {
                    results.Add(item.Key);
                }
            }

            return results.ToArray();
        }
    }
}
