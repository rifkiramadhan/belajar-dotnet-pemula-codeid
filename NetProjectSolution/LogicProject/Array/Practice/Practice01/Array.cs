using System;

namespace LogicProject.Array.Practice.Practice01
{
    internal class Array
    {
        // PowTwo
        public static int[] PowNumber(int n)
        {
            var newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }

        public static int[] PowNumberWithMathPow(int n)
        {
            var newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i] = (int)Math.Pow(2, i);
            }
            return newArray;
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        // OddNumber
        public static int[] PowNumberTwo(int n)
        {
            var newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }
        public static int[] OddNumber(int n)
        {
            var newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i] = (2 * i) + 1;
            }
            return newArray;
        }

        // Fibonacci
        public static int[] PowNumberThree(int n)
        {
            var newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }

        public static int[] Fibonacci(int n)
        {
            var newArray = new int[n];
            newArray[0] = 1;
            newArray[1] = 1;

            for (int i = 2; i < n; i++)
            {
                newArray[i] = newArray[i - 2] + newArray[i - 1];
            }
            return newArray;
        }

        // Palindrome
        public static int[] PowNumberFour(int n)
        {
            var newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == n / 2)
                    newArray[i] = 2;
                else
                    newArray[i] = 5;
            }
            return newArray;
        }

        public static bool IsPalindrome(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                    return false;
            }
            return true;
        }

        // Rotate Array
        public static int[] RotateArray(int[] arr)
        {
            var temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;
            return arr;
        }

        // Sorting Array With Swap
        public static int[] OrderSwapArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var minIndex = i;
                var minValue = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < minValue)
                    {
                        minIndex = j;
                        minValue = arr[j];
                    }
                }
                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }

        // Menambahkan overload method untuk membuat array
        public static int[] OrderSwapArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            return OrderSwapArray(arr);
        }
    }
}
