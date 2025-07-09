using System.Numerics;

namespace _32_ProblemNo_599
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-index-sum-of-two-lists/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { "KFC", "Shogun", "Burger King" };
            solution.FindRestaurant(list1, list2);
        }
    }

    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (string item in list1)
            {
                if (list2.Contains(item))
                {
                    int indexInList1 = Array.IndexOf(list1, item);
                    int indexInList2 = Array.IndexOf(list2, item);

                    int total = indexInList1 + indexInList2;
                    keyValuePairs.Add(item, total);
                }
            }

            int minumumValue = keyValuePairs.Values.Min();
            return keyValuePairs.Select(y => y).Where(z => z.Value == minumumValue).Select(k => k.Key).ToArray();
        }
    }
}
