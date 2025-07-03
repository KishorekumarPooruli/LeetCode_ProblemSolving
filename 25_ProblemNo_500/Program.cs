using System.Linq;

namespace _25_ProblemNo_500
{
    /// <summary>
    /// https://leetcode.com/problems/keyboard-row/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        }
    }

    public class Solution()
    {
        public string[] FindWords(string[] words)
        {
            List<string> results = new List<string>();
            char[][] datasets = {
                new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' },
                new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' },
                new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' }
            };

            foreach (var word in words) 
            {
                var instance = word.ToLower();
                char[] selectedDataSet = new char[] {};
                for (int j = 0; j < datasets.Length; j++)
                {
                    if (datasets[j].Contains(instance[0]))
                    {
                        selectedDataSet = datasets[j];
                        break;
                    }
                }

                List<bool> bools = new List<bool>();
                for (int i = 0; i < instance.Length; i++)
                {
                    char charInstance = instance[i];
                    if (selectedDataSet.Contains(charInstance))
                    {
                        bools.Add(true);
                    }
                    else if (selectedDataSet.Any(y=>y == charInstance))
                    {
                        var xy = instance[i];


                    }
                    else
                    {
                        bools.Add(false);
                    }
                }

                if (bools.All(y => y == true))
                {
                    results.Add(word);
                }
            }

            return results.ToArray();
        }
    }
}