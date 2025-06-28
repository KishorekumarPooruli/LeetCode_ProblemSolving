namespace _15_ProblemNo_303
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/description/
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            NumArray numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            int value = numArray.SumRange(0, 2);
            value = numArray.SumRange(2, 5);
            value = numArray.SumRange(0, 5);
        }
    }

    public class NumArray
    {
        public int[] Nums { get; set; }

        public NumArray(int[] nums)
        {
            this.Nums = nums;
        }

        public int SumRange(int left, int right)
        {
            ////Index: 0   1    2    3   4    5
            ////Value: -2   0   3  - 5   2  - 1


            IEnumerable<int> finalCollection = this.Nums.Take(right + 1).Skip(left);
            int sum = 0;
            foreach (var item in finalCollection)
            {
                sum += item;
            }

            return sum;
        }
    }
}
