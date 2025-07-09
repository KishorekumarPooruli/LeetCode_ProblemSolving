using System.Data.Common;

namespace _31_ProblemNo_598
{
    /// <summary>
    /// https://leetcode.com/problems/range-addition-ii/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] jaggedInput = new int[2][];
            jaggedInput[0] = new int[] { 2, 2 };
            jaggedInput[1] = new int[] { 3, 3 };
            //// TIME COMPLEXITY: O(N)
            ////int[][] jaggedInput = new int[][]
            ////{
            ////    new int[] {2, 2},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3},
            ////    new int[] {2, 2},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3},
            ////    new int[] {2, 2},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3},
            ////    new int[] {3, 3}
            ////};
            int output = solution.MaxCount(3,3, jaggedInput);
        }
    }

    public class Solution
    {
        public int MaxCountKishore(int m, int n, int[][] ops)
        {
            int[,] outputArray = new int[m, n];
            foreach (var instance in ops)
            {
                int row = instance[0];
                int column = instance[1];

                for (int i = 0; i < outputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < outputArray.GetLength(1); j++)
                    {
                        if (i < row && j < column)
                        {
                            outputArray[i, j] = outputArray[i, j] + 1;
                        }
                    }
                }
            }

            List<int> output = new List<int>();
            for (int i = 0; i < outputArray.GetLength(0); i++)
            {
                for (int j = 0; j < outputArray.GetLength(1); j++)
                {
                    output.Add(outputArray[i, j]);
                }
            }

            return output.Count(y => y == output.Max());
        }


        public int MaxCount(int m, int n, int[][] ops)
        {
            //// CO-PILOT
            int minRow = m;
            int minCol = n;

            foreach (var op in ops)
            {
                minRow = Math.Min(minRow, op[0]);
                minCol = Math.Min(minCol, op[1]);
            }

            return minRow * minCol;
        }
    }
}
