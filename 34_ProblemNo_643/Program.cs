using System;

namespace _34_ProblemNo_643
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        }
    }

    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            List<int> sum = new List<int>(); 
            double divider = (double)k;
            List<int> inputDataSet = new List<int>();
            int sumOfDataSet = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> futureElements = nums.Skip(i).Take(k).ToList();

                if (futureElements.Count == k && k != 1)
                {
                    if (inputDataSet.Count == 0)
                    {
                        inputDataSet.AddRange(futureElements);
                        for (int j = 0; j < inputDataSet.Count; j++)
                        {
                            sumOfDataSet += inputDataSet[j];
                        }
                    }
                    else
                    {
                        //// Sliding Logic
                        int removableElement = inputDataSet[0];
                        int indexOfLastElement = inputDataSet.Count - 1;
                        if (indexOfLastElement + 1 < nums.Length)
                        {
                            sumOfDataSet = sumOfDataSet - inputDataSet.First() + futureElements.Last();
                            inputDataSet = futureElements;
                        }
                    }

                    sum.Add(sumOfDataSet);
                }
                else
                {
                    if (k == 1)
                    {
                        sum.Add(nums.Max());
                    }
                }
                
            }

            return sum.Max() / divider;
        }

        public double FindMaxAverageOptimized(int[] nums, int k)
        {
            // Initial window sum
            int windowSum = 0;
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }

            int maxSum = windowSum;

            // Slide the window
            for (int i = k; i < nums.Length; i++)
            {
                windowSum = windowSum - nums[i - k] + nums[i];
                if (windowSum > maxSum)
                {
                    maxSum = windowSum;
                }
            }

            return (double)maxSum / k;
        }
    }
}
