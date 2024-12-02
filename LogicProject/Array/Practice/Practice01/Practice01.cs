using System;

namespace LogicProject.Array.Practice.Practice01
{
    internal class Practice01
    {
        public static int[] OrderEvenBeforeOdd(int[] arr)
        {
            int[] result = (int[])arr.Clone();
            int n = result.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (result[j] % 2 == 0 && result[j + 1] % 2 == 0 && result[j] > result[j + 1])
                    {
                        // Swap
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (result[j] % 2 == 1 && result[j + 1] % 2 == 1 && result[j] > result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (result[j] % 2 == 1 && result[j + 1] % 2 == 0)
                    {
                        // Swap
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
        }
    }
}
