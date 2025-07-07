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
            int[][] mat = { new int[] { 1, 2 } };
            solution.Testing2();
            //// TIME COMPLECITY: O(N)
            solution.MatrixReshape(mat, 1, 1);

        }
    }

    public class Solution

    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int[][] output;

            //// Identifies the total Elements present in jagged array
            int totalElements = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                totalElements += mat[i].Length;
            }

            if (mat.Length == r && totalElements == c)
            {
                //// According to Description 
                output = mat;
            }
            else
            {
                //// Converting Jagged Array to Single Dimensional Array
                int[] inputValues = new int[totalElements];

                ///// Copy paste values from Jagged Array to Single Dimensional Array
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
                    //// Checking if all the elements inputted can be placed in the specified row and column index 
                } 


                if (totalElementCanBePlaced != inputValues.Length)
                {
                    //// according to description
                    output = mat;
                }
                else
                {
                    //// forming the jagged array according to the ROW AND COLUMN INPUT
                    int count = 0;
                    for (int i = 0; i < output.Length; i++)
                    {
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
