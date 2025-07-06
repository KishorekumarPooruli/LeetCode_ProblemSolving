namespace _26_ProblemNo_506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindRelativeRanks(new int[] { 10, 3, 8, 9, 4 });
            //// O(1) < O(log n) < O(n) < O(n log n) < O(n²) < O(n³) < O(2ⁿ) < O(n!)
            //// This below program is O(n log n) or O(n²) TIME COMPLEXITY 
        }
    }

    public class Solution()
    {
        public string[] FindRelativeRanks(int[] score)
        {
            int[] input = new int[score.Length];
            Array.Copy(score, input, score.Length);
            Array.Sort(input);
            Array.Reverse(input);

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            int counter = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (counter <= 3)
                {
                    if (counter == 1)
                    {
                        keyValuePairs.Add(input[i], "Gold Medal");
                    }
                    else if (counter == 2)
                    {
                        keyValuePairs.Add(input[i], "Silver Medal");
                    }
                    else
                    {
                        keyValuePairs.Add(input[i], "Bronze Medal");
                    }
                }
                else
                {
                    keyValuePairs.Add(input[i], counter.ToString());
                }

                counter++;
            }

            List<string> output = new List<string>();

            for (int j = 0; j < score.Length; j++)
            {
                //// since FIRST() is used again it iterates and find the element instread use INDEX TO OPTIMIZE THE CODE 
                ////var keyValue = keyValuePairs.First(y => y.Key == score[j]);
                ////output.Add(keyValue.Value);
                var instance = keyValuePairs[score[j]];
                output.Add(instance);
            }

            return output.ToArray();
        }
    }
}
