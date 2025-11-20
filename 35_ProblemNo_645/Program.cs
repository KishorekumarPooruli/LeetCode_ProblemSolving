using System;

namespace _35_ProblemNo_645
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindErrorNums(new int[] { 3, 2, 3, 4, 6, 5 });
        }
    }

    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            List<int> inputDataSet = new List<int>();
            inputDataSet.Add(0);
            inputDataSet.AddRange(nums);

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> missingElement = new List<int>();
            for(int i = 0; i < inputDataSet.Count; i++)
            {
                int value = inputDataSet[i];

                if (i != inputDataSet[i])
                {
                    missingElement.Add(value);
                    int previousIndex = i - 1;
                    missingElement.Add(inputDataSet[previousIndex] + 1);
                }

            }


            for (int i = 0; i < inputDataSet.Count; i++)
            {
                if (!keyValuePairs.ContainsKey(inputDataSet[i]))
                {
                    keyValuePairs.Add(inputDataSet[i], 1);
                }
                else
                {
                    missingElement.Add(inputDataSet[i]);
                    int previousIndex = i - 1;
                    missingElement.Add(inputDataSet[i] + 1);
                    keyValuePairs[inputDataSet[i]] = keyValuePairs[inputDataSet[i]] + 1;
                }
            }

            ////foreach (int num in nums)
            ////{
            ////    if (!keyValuePairs.ContainsKey(num))
            ////    {
            ////        keyValuePairs.Add(num, 1);
            ////    }
            ////    else
            ////    {
            ////        missingElement.Add(num);

            ////        keyValuePairs[num] = keyValuePairs[num] + 1;
            ////    }
            ////}
            ////var abc = keyValuePairs.Where(y => y.Value > 1);
            ////int maxElement = nums.Max();
            ////List<int> missingElemenet = new List<int>();
            ////////int counter = nums.Min();
            ////////foreach (var item in nums)
            ////////{
            ////////    if (counter != item)
            ////////    {
            ////////        missingElemenet.Add(item);
            ////////        missingElemenet.Add(counter);
            ////////    }

            ////////    counter++;

            ////////}
            ////var xyz = nums.Where(y => y == y++);

            ////List<int> inputDataSet = new List<int>();
            ////inputDataSet.Add(0);
            ////inputDataSet.AddRange(nums);
            ////inputDataSet = inputDataSet.OrderBy(x => x).ToList();

            ////for (int i = 0; i < inputDataSet.Count; i++)
            ////{
            ////    if (i != inputDataSet[i])
            ////    {
            ////        missingElemenet.Add(inputDataSet[i]);
            ////        missingElemenet.Add(i); //// Position
            ////    }
            ////}

            return missingElement.ToArray();
        }
    }
}