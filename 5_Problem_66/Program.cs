using System.Numerics;

namespace _5_Problem_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] output = solution.PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 });
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            string sumOfAllArray = "";
            for (int i = 0; i < digits.Length; i++)
            {
                if (string.IsNullOrEmpty(sumOfAllArray))
                {
                    sumOfAllArray = Convert.ToString(digits[i]);
                }
                else
                {
                    sumOfAllArray = string.Concat(sumOfAllArray, Convert.ToString(digits[i]));
                }
            }

            BigInteger sumOfArray;
                BigInteger.TryParse(sumOfAllArray, out sumOfArray);
            sumOfArray = sumOfArray + 1;
            sumOfAllArray = Convert.ToString(sumOfArray);
            int[] finalArray = new int[sumOfAllArray.Length];
            for (int j = 0; j < sumOfAllArray.Length; j++)
            {
                finalArray[j] = Convert.ToInt32(sumOfAllArray[j].ToString());
            }

            return finalArray;

        }
    }
}
