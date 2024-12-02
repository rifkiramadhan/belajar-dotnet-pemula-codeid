using System;
using System.Collections.Generic;

namespace LogicProject.Array.Challenges
{
    internal class Challenges06
    {
        public static Dictionary<int, int> FrequentElement(int[] arr)
        {
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyDict.ContainsKey(num))
                {
                    frequencyDict[num]++;
                }
                else
                {
                    frequencyDict[num] = 1;
                }
            }

            return frequencyDict;
        }

        public static int[] Addition(int[] arr1, int[] arr2)
        {
            int maxLength = Math.Max(arr1.Length, arr2.Length);

            List<int> result = new List<int>();

            int carry = 0;

            for (int i = 1; i <= maxLength; i++)
            {
                int num1 = arr1.Length - i >= 0 ? arr1[arr1.Length - i] : 0;
                int num2 = arr2.Length - i >= 0 ? arr2[arr2.Length - i] : 0;

                int sum = num1 + num2 + carry;

                result.Insert(0, sum % 10);

                carry = sum / 10;
            }

            if (carry > 0)
            {
                result.Insert(0, carry);
            }

            return result.ToArray();
        }
    }
}
