using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LogicProject.Array.Practice.Practice01;
using LogicProject.Challenges;
using LogicProject.Practice.Practice01;
using static LogicProject.Array.Challenges.Challenges04;

namespace LogicProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == Looping ==

            // Practice
            //Looping.TriangleOne();
            //Looping.TriangleTwo();
            //Looping.TriangleThree();
            //Looping.TriangleFour();

            // Challenge01
            //Challenge.Challenges01.Challenge01();
            //Challenge.Challenges01.Challenge02();
            //Challenge.Challenges01.Challenge03();
            //Challenge.Challenges01.Challenge04();

            // Challenge02
            //Challenges02.Challenge01();
            //Challenges02.Challenge02();
            //Challenges02.Challenge03();
            //Challenges02.Challenge04();

            // Challenge03
            //Challenges03.Challenge01();
            Challenges03.ShowPattern(9);
            //Challenges03.Challenge02();

            // Challenge04
            //Challenges04.Challenge01(5);
            //Challenges04.Challenge02(9);


            // == Array ==

            // Practice

            // 1. PowTwo
            //int[] result1 = Array.Practice.Practice01.Array.PowNumber(5);
            //Array.Practice.Practice01.Array.DisplayArray(result1);

            //int[] result2 = Array.Practice.Practice01.Array.PowNumberWithMathPow(5);
            //Array.Practice.Practice01.Array.DisplayArray(result2);

            // 2. OddNumber
            //int[] result3 = Array.Practice.Practice01.Array.PowNumberTwo(5);
            //Array.Practice.Practice01.Array.DisplayArray(result3);

            //int[] result4 = Array.Practice.Practice01.Array.OddNumber(5);
            //Array.Practice.Practice01.Array.DisplayArray(result4);

            // 3. Fibonacci
            //int[] result5 = Array.Practice.Practice01.Array.PowNumberThree(5);
            //Array.Practice.Practice01.Array.DisplayArray(result5);

            //int[] result6 = Array.Practice.Practice01.Array.Fibonacci(5);
            //Array.Practice.Practice01.Array.DisplayArray(result6);

            // 4. Palindrome
            //int[] result7 = Array.Practice.Practice01.Array.PowNumberFour(5);
            //Array.Practice.Practice01.Array.DisplayArray(result7);

            //int[] palindromeArray = new int[] { 5, 5, 2, 5, 5 };
            //Array.Practice.Practice01.Array.DisplayArray(palindromeArray);

            // Test array yang diberikan
            //int[] testArray = new int[] { 5, 2, 3, 1, 5, 5, 5 };
            //Console.WriteLine($"Is {string.Join(", ", testArray)} palindrome? {Array.Practice.Practice01.Array.IsPalindrome(testArray)}");

            // 5. Rotate Array
            //int[] result8 = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Array sebelum rotasi:");
            //Array.Practice.Practice01.Array.DisplayArray(result8);

            //int[] arrayToRotate = new int[] { 1, 5, 3, 4, 9 };
            //Array.Practice.Practice01.Array.DisplayArray(arrayToRotate);

            //arrayToRotate = Array.Practice.Practice01.Array.RotateArray(arrayToRotate);

            //arrayToRotate[arrayToRotate.Length - 1] = 5;

            //Console.WriteLine("Array setelah rotasi:");
            //Array.Practice.Practice01.Array.DisplayArray(result8);
            //Array.Practice.Practice01.Array.DisplayArray(arrayToRotate);

            // 6. Sorting Array With Swap
            //int[] result9 = new int[] { 1, 2, 3, 4, 5 };
            //int[] unsortedArray = new int[] { 9, 3, 2, 4, 1 };

            //Console.WriteLine("Array sebelum sorting:");

            //Array.Practice.Practice01.Array.DisplayArray(result9);
            //Array.Practice.Practice01.Array.DisplayArray(unsortedArray);

            //unsortedArray = Array.Practice.Practice01.Array.OrderSwapArray(unsortedArray);

            //Console.WriteLine("Array setelah sorting:");

            //Array.Practice.Practice01.Array.DisplayArray(result9);
            //Array.Practice.Practice01.Array.DisplayArray(unsortedArray);


            // Challennges Array

            // 1.OrderEvenBeforeOdd
            //int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] input2 = { 3, 4, 5, 2, 10 };
            //int[] input3 = { 2, 4, 6, 10, 1 };

            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input1));

            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input2));

            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Array.Challenges.Challenges01.OrderEvenBeforeOdd(input3));

            // 2. String Palindrome
            //string[] input1 = new string[] { "donout", "king", "donout" };
            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input1));

            //string[] input2 = new string[] { "min", "max", "min" };
            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input2));

            //string[] input3 = new string[] { "true", "false", "false" };
            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.WriteLine("Result: " + Array.Challenges.Challenges02.IsPalindrome(input3));

            // 3. AddOnePlus
            //int[] input1 = new int[] { 1, 3, 2, 4 };
            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input1)));

            //int[] input2 = new int[] { 1, 4, 8, 9 };
            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input2)));

            //int[] input3 = new int[] { 9, 9, 9, 9 };
            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges03.AddOnePlus(input3)));


            // == Logic Array ==

            // Practice 01
            //int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] input2 = {2, 4, 6, 1, 8 };
            //int[] input3 = { 2, 4, 6, 8, 1 };

            //Console.WriteLine("Input: " + string.Join(", ", input1));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input1));

            //Console.WriteLine("\nInput: " + string.Join(", ", input2));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input2));

            //Console.WriteLine("\nInput: " + string.Join(", ", input3));
            //Console.Write("Result: ");
            //Array.Challenges.Challenges01.DisplayArray(Practice01.OrderEvenBeforeOdd(input3));


            // 1. Same Element
            //int[] arr1 = new int[] { 1, 2, 4, 7, 8 };
            //int[] arr2 = new int[] { 2, 3, 7, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr1, arr2)));

            //// Test Case 2
            //int[] arr3 = new int[] { 1, 2, 7, 4, 7, 8 };
            //int[] arr4 = new int[] { 7, 7, 3, 2, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr3, arr4)));

            //// Test Case 3
            //int[] arr5 = new int[] { 2, 4, 6, 8 };
            //int[] arr6 = new int[] { 1, 3, 5, 7, 9 };
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges04.SameElement(arr5, arr6)));

            // 2. DiffSet            
            //int[] A = new int[] { 1, 2, 3, 4, 5 };
            //int[] B = new int[] { 2, 4, 6, 7 };

            //Console.WriteLine("Result DiffSetAB: " + string.Join(", ", SetOperations.DiffSetAB(A, B)));

            //Console.WriteLine("Result DiffSetBA: " + string.Join(", ", SetOperations.DiffSetBA(A, B)));

            //Console.WriteLine("Result IntersectAB: " + string.Join(", ", SetOperations.IntersectAB(A, B)));

            //Console.WriteLine("Result Union: " + string.Join(", ", SetOperations.Union(A, B)));

            // 3. Reverse List
            //int[] input = new int[] { 1, 2, 3, 4 };
            //int[] reversed = Array.Challenges.Challenges05.ReverseList(input);
            //Console.WriteLine("Result: " + string.Join(", ", reversed));

            // 4. Remove Duplicate
            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 1, 1, 2, 3, 4, 1, 2, 3 })));

            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 7, 5, 3, 5, 1 })));

            //Console.WriteLine("Result: " + string.Join(", ", Array.Challenges.Challenges05.RemoveDuplicate(new int[] { 1, 1, 1, 1 })));

            // 5. Frequent Element
            //int[] testArray1 = { 1, 2, 3, 4, 4, 4, 3, 3, 2, 4 };
            //Dictionary<int, int> result1 = Array.Challenges.Challenges06.FrequentElement(testArray1);

            //Console.WriteLine("Result: ");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.Key}={item.Value}");
            //}

            //Console.WriteLine("\n");

            //int[] testArray2 = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            //Dictionary<int, int> result2 = Array.Challenges.Challenges06.FrequentElement(testArray2);

            //Console.WriteLine("Result: ");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Key}={item.Value}");
            //}

            // 6. Array Addition Method
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int[] result1 = Array.Challenges.Challenges06.Addition(arr1, arr2);
            //Console.WriteLine("Result: " + string.Join(", ", result1));

            //int[] arr3 = { 9, 2, 7 };
            //int[] arr4 = { 1, 3, 5 };
            //int[] result2 = Array.Challenges.Challenges06.Addition(arr3, arr4);
            //Console.WriteLine("Result: " + string.Join(", ", result2));

            // 7. Merge List
            // Test case 1
            //int[] mergeList1 = { 1, 4, 7, 12, 20 };
            //int[] mergeList2 = { 10, 15, 17, 33 };
            //int[] result1 = Array.Challenges.Challenges07.MergeList(mergeList1, mergeList2);

            //Console.WriteLine("Result: " + string.Join(", ", result1));

            //// Test case 2
            //int[] mergeList3 = { 2, 3, 5, 7 };
            //int[] mergeList4 = { 11, 13, 17 };
            //int[] result2 = Array.Challenges.Challenges07.MergeList(mergeList3, mergeList4);
            //Console.WriteLine("Result: " + string.Join(", ", result2));

            //// Test case 3
            //int[] mergeList5 = { 2, 3, 5, 7, 11 };
            //int[] mergeList6 = { 7, 11, 13, 17 };
            //int[] result3 = Array.Challenges.Challenges07.MergeList(mergeList5, mergeList6);
            //Console.WriteLine("Result: " + string.Join(", ", result3));


            // Interviewzen
            // Soal 1
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(15)));
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(25)));
            //Console.WriteLine("Output: " + string.Join(", ", Interviewzen.Challenges.ShowPrimeNumber(50)));

            // Soal 2
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.Fibo(10)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.Fibo(15)));

            // Soal 3
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(6)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(24)));
            //Console.WriteLine("Output: " + string.Join(" ", Interviewzen.Challenges.FindDivisor(7)));

            // Soal 4
            //Interviewzen.Challenges.ShowPattern(5);
            //Console.WriteLine();
            //Interviewzen.Challenges.ShowPattern(9);

        }
    }
}
