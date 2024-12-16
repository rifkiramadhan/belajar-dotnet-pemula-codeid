using System.Collections.Generic;

namespace LogicProject.Array.Challenges
{
    internal class Challenges04
    {
        public static int[] SameElement(int[] arr1, int[] arr2)
        {
            List<int> commonElements = new List<int>();

            foreach (int num1 in arr1)
            {
                foreach (int num2 in arr2)
                {
                    if (num1 == num2 && !commonElements.Contains(num1))
                    {
                        commonElements.Add(num1);
                    }
                }
            }

            int[] result = commonElements.ToArray();
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        // Swap elements
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }

        public class SetOperations
        {
            public static int[] DiffSetAB(int[] arrA, int[] arrB)
            {
                List<int> result = new List<int>();

                foreach (int num in arrA)
                {
                    bool exists = false;
                    foreach (int b in arrB)
                    {
                        if (num == b)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists && !result.Contains(num))
                    {
                        result.Add(num);
                    }
                }

                int[] sortedResult = result.ToArray();
                for (int i = 0; i < sortedResult.Length - 1; i++)
                {
                    for (int j = 0; j < sortedResult.Length - i - 1; j++)
                    {
                        if (sortedResult[j] > sortedResult[j + 1])
                        {
                            int temp = sortedResult[j];
                            sortedResult[j] = sortedResult[j + 1];
                            sortedResult[j + 1] = temp;
                        }
                    }
                }

                return sortedResult;
            }

            public static int[] DiffSetBA(int[] arrA, int[] arrB)
            {
                List<int> result = new List<int>();

                foreach (int num in arrB)
                {
                    bool exists = false;
                    foreach (int a in arrA)
                    {
                        if (num == a)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists && !result.Contains(num))
                    {
                        result.Add(num);
                    }
                }

                int[] sortedResult = result.ToArray();
                for (int i = 0; i < sortedResult.Length - 1; i++)
                {
                    for (int j = 0; j < sortedResult.Length - i - 1; j++)
                    {
                        if (sortedResult[j] > sortedResult[j + 1])
                        {
                            int temp = sortedResult[j];
                            sortedResult[j] = sortedResult[j + 1];
                            sortedResult[j + 1] = temp;
                        }
                    }
                }

                return sortedResult;
            }

            public static int[] IntersectAB(int[] arrA, int[] arrB)
            {
                List<int> result = new List<int>();

                foreach (int a in arrA)
                {
                    foreach (int b in arrB)
                    {
                        if (a == b && !result.Contains(a))
                        {
                            result.Add(a);
                        }
                    }
                }

                int[] sortedResult = result.ToArray();
                for (int i = 0; i < sortedResult.Length - 1; i++)
                {
                    for (int j = 0; j < sortedResult.Length - i - 1; j++)
                    {
                        if (sortedResult[j] > sortedResult[j + 1])
                        {
                            int temp = sortedResult[j];
                            sortedResult[j] = sortedResult[j + 1];
                            sortedResult[j + 1] = temp;
                        }
                    }
                }

                return sortedResult;
            }

            public static int[] Union(int[] arrA, int[] arrB)
            {
                List<int> result = new List<int>();

                foreach (int num in arrA)
                {
                    if (!result.Contains(num))
                    {
                        result.Add(num);
                    }
                }

                foreach (int num in arrB)
                {
                    if (!result.Contains(num))
                    {
                        result.Add(num);
                    }
                }

                int[] sortedResult = result.ToArray();
                for (int i = 0; i < sortedResult.Length - 1; i++)
                {
                    for (int j = 0; j < sortedResult.Length - i - 1; j++)
                    {
                        if (sortedResult[j] > sortedResult[j + 1])
                        {
                            int temp = sortedResult[j];
                            sortedResult[j] = sortedResult[j + 1];
                            sortedResult[j + 1] = temp;
                        }
                    }
                }

                return sortedResult;
            }
        }
    }
}
