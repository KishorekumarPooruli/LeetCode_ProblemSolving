namespace _33_ProblemNo_628
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MaximumProduct(new int[] { -1, -2, -3, -4 });
        }
    }

    public class Solution
    {
        //// Didnt submit
        public int MaximumProduct(int[] nums)
        {
            List<Tuple<int, int, int>> dataSets = new List<Tuple<int, int, int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                int value1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int value2 = nums[j];
                    for (int z = j + 1 ; z < nums.Length; z++)
                    {
                        int value3 = nums[z];
                        dataSets.Add( new Tuple<int, int, int>(value1, value2, value3));
                    }
                }
            }

            int maxSum = int.MinValue;

            foreach (var item in dataSets)
            {
                int result = item.Item1 * item.Item2 * item.Item3;
                if (result > maxSum)
                {
                    maxSum = result;
                }                
            }            

            return maxSum;
        }
    }
}
