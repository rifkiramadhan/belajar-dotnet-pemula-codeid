using System;

namespace LogicProject.Array.Challenges
{
    internal class Challenges01
    {
        public static int[] OrderEvenBeforeOdd(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] % 2 == 0 && arr[j] % 2 == 0 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] % 2 == 1 && arr[j] % 2 == 1 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] % 2 == 1 && arr[j] % 2 == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
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
