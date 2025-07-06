namespace _27_ProblemNo_561
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ArrayPairSum(new int[] { -9046, -1719, 11, 41, 279, 1118, 2047, 3855, 4925, 7380, 8446, 8477 });
        }
    }

    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            ////nums = nums.Distinct().ToArray();
            Array.Sort(nums);
            List<ValueTuple<int, int>> generatedCombinations = new List<ValueTuple<int, int>>();
            int pairs = nums.Length / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                var afterCurrentValues = nums.Skip(i +1 ).ToArray();

                foreach(var instance in afterCurrentValues)
                {
                    generatedCombinations.Add(new ValueTuple<int, int>(nums[i], instance));
                }
            }

            //////foreach(var i in nums)
            //////{
            //////    int currentIndex = Array.FindIndex(nums, i, );

            //////}

            int column = generatedCombinations.Count / pairs;
            ValueTuple<int, int>[,] inputDataObject = new ValueTuple<int, int>[pairs, column];
            int temp = 0;
            for (int i = 0; i < inputDataObject.GetLength(0); i++)
            {
                for (int j = 0; j < inputDataObject.GetLength(1); j++)
                {
                    inputDataObject[i, j] = generatedCombinations[temp];
                    temp++;
                }
            }

            string outputx = inputDataObject.ToString();
            List<int> output = new List<int>();
            for (int i = 0; i < column; i++)
            {
                List<int> rowSums = new List<int>();
                for (int j = 0; j < pairs; j++)
                {
                    rowSums.Add(Math.Min(inputDataObject[j, i].Item1, inputDataObject[j, i].Item2));
                }

                int sum = 0;
                foreach(var rowSum in rowSums)
                {
                    sum += rowSum;
                }

                output.Add(sum);
            }


            return output.Max();
        }
    }
}
