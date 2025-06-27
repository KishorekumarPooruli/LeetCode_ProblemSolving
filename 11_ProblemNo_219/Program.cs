namespace _11_ProblemNo_219
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate-ii/
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
        }
    }

    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            bool result = false;
            List<int> numsList = nums.ToList();
            int[] uniqueArray = nums.Distinct().ToArray();
            if (uniqueArray.Length != nums.Length)
            {
                for (int i = 0; i < numsList.Count; i++)
                {
                    int value = numsList[i];
                    int indexOfCurrent = i;
                    List<int> remainingNums = nums.Skip(indexOfCurrent + 1).ToList();
                    int indexOfDuplicate = -1;
                    if (remainingNums.Any(y => y == value))
                    {
                        for(int j = indexOfCurrent + 1; j < numsList.Count; j++)
                        {
                            if (numsList[j] == value)
                            {
                                indexOfDuplicate = j;
                                break;
                            }
                        }

                        if (indexOfDuplicate > 0)
                        {
                            int mathResult = Math.Abs(indexOfCurrent - indexOfDuplicate);
                            if (mathResult <= k)
                            {
                                result = true;
                                break;
                            }
                        }
                    }                    
                }
            }

            return result;
        }
    }
}
