using System;

namespace _28_ProblemNo_566
{
    /// <summary>
    /// https://leetcode.com/problems/reshape-the-matrix/description/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] mat = { new int[] { 1, 2 }};
            //// TIME COMPLECITY: O(N)
            solution.MatrixReshape(mat, 1, 1);
        }
    }

    public class Solution

    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int[][] output;
            int inputRows = mat.Length;
            int column = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                column += mat[i].Length;
            }

            if (inputRows == r && column == c)
            {
                output = mat;
            }
            else
            {
                int[] inputValues = new int[column];

                int counter = 0;
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        inputValues[counter] = mat[i][j];
                        counter++;
                    }
                }


                output = new int[r][];
                int totalElementCanBePlaced = 0;
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = new int[c];
                    totalElementCanBePlaced += output[i].Length;
                }


                if(totalElementCanBePlaced != inputValues.Length)
                {
                    output = mat;
                }
                else
                {
                    int count = 0;
                    for (int i = 0; i < output.Length; i++)
                    {
                        ////output[i] = new int[c];
                        for (int j = 0; j < output[i].Length; j++)
                        {
                            output[i][j] = inputValues[count];
                            count++;
                        }
                    }
                }                
            }

            return output;
        }
    }
}
