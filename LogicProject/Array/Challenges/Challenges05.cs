using System.Collections.Generic;

namespace LogicProject.Array.Challenges
{
    internal class Challenges05
    {
        public static int[] ReverseList(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            return arr;
        }

        public static int[] RemoveDuplicate(int[] arr)
        {
            // Use HashSet to keep track of unique elements while preserving order
            HashSet<int> uniqueSet = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                // Only add to result if not already in the set
                if (uniqueSet.Add(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
