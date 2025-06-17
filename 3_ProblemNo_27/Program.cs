namespace _3_ProblemNo_27
{
    using System.Linq;

    /// <summary>
    /// https://leetcode.com/problems/remove-element/?envType=problem-list-v2&envId=array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            solution.RemoveElement(new int[] { -1, 3, 5, 6 }, 0);
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] inputArray, int removeValue)
        {
            int length = inputArray.Length;
            List<int> inputList = inputArray.ToList();
            inputList.RemoveAll(y => y == removeValue); //// used LINQ Default Method

            for (int i = 0; i < inputArray.Length; i++)
            {
                //// COPY LIST VALUES TO SOURCE ARRAY with Same Length
                if (i < inputList.Count)
                {

                    inputArray[i] = inputList[i];
                }
                else
                {
                    inputArray[i] = 0;
                }
            }

            return inputList.Count; //// returns Unique Element Count
        }
    }
}
