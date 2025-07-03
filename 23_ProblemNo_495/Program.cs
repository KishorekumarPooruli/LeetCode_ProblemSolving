using System.Collections.Concurrent;

namespace _23_ProblemNo_495
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindPoisonedDuration(new int[] { 1, 2, 3, 4, 5 }, 5);
        }
    }

    public class Solution()
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int total = 0;

            for (int i = 0; i < timeSeries.Length - 1; i++)
            {
                int gap = timeSeries[i + 1] - timeSeries[i];
                total = total + Math.Min(gap, duration);
            }

            // Add duration for the last attack
            total += duration;

            return total;
        }



        public int FindPoisonedDurationVersion4(int[] timeSeries, int duration)
        {
            timeSeries = timeSeries.Distinct().ToArray();
            ConcurrentBag<int> attacks = new ConcurrentBag<int>();
            Parallel.For(0, timeSeries.Length, i =>
            {
                int keyAttack = timeSeries[i];
                for (int j = keyAttack; j < keyAttack + duration; j++)
                {
                    attacks.Add(j);
                }
            });

            return attacks.Distinct().ToArray().Length;
        }

        public int FindPoisonedDurationVersion3(int[] timeSeries, int duration)
        {
            timeSeries = timeSeries.Distinct().ToArray();
            List<int> attacks = new List<int>();
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (attacks.Contains(timeSeries[i]))
                {
                    int keyAttack = timeSeries[i];
                    for (int j = keyAttack; j < keyAttack + duration; j++)
                    {
                        attacks.Add(j);
                    }
                }
                else
                {
                    int keyAttack = timeSeries[i];
                    for (int j = keyAttack; j < keyAttack + duration; j++)
                    {
                        attacks.Add(j);
                    }
                }
            }

            return attacks.Distinct().ToArray().Length;
        }

        public int FindPoisonedDurationVersion2(int[] timeSeries, int duration)
        {
            timeSeries = timeSeries.Distinct().ToArray();
            List<int> attacks = new List<int>();
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (attacks.Contains(timeSeries[i]))
                {
                    attacks.RemoveAll(y => y >= timeSeries[i]);
                    int keyAttack = timeSeries[i];
                    for (int j = keyAttack; j < keyAttack + duration; j++)
                    {
                        attacks.Add(j);
                    }
                }
                else
                {
                    int keyAttack = timeSeries[i];
                    for (int j = keyAttack; j < keyAttack + duration; j++)
                    {
                        attacks.Add(j);
                    }
                }                
            }

            return attacks.Count;
        }

        public int FindPoisonedDurationVersion1(int[] timeSeries, int duration)
        {
            timeSeries = timeSeries.Distinct().ToArray();
            List<int> attacks = new List<int>();

            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (keyValuePairs.Any(y => y.Value.Contains(timeSeries[i])))
                {
                    var instance = keyValuePairs.FirstOrDefault(y => y.Value.Contains(timeSeries[i]));
                    instance.Value.RemoveAll(y => y >= timeSeries[i]);
                    this.AddAttackDetails(timeSeries, duration, keyValuePairs, i);
                }
                else
                {
                    this.AddAttackDetails(timeSeries, duration, keyValuePairs, i);
                }
            }

            return keyValuePairs.Values.Sum(y=>y.Count);
        }

        private void AddAttackDetails(int[] timeSeries, int duration, Dictionary<int, List<int>> keyValuePairs, int i)
        {
            int keyAttack = timeSeries[i];
            List<int> attackDuration = new List<int>();

            for (int j = keyAttack; j < keyAttack + duration; j++)
            {
                attackDuration.Add(j);
            }

            keyValuePairs.Add(keyAttack, attackDuration);
        }
    }
}
