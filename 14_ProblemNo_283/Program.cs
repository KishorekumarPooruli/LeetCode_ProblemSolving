namespace _14_ProblemNo_283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        }
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int countZeros = nums.Count(y => y == 0);
            if (countZeros > 0) 
            {
                List<int> nonZeroes = nums.ToList();
                nonZeroes.RemoveAll(y => y == 0);

                for (int i = 0; i < countZeros; i++)
                {
                    nonZeroes.Add(0);
                }

                int[] result = nonZeroes.ToArray();
                Array.Copy(result, nums, result.Length);
            }
        }
    }
}
