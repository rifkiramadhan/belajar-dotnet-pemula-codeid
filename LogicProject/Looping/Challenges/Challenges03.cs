using System;

namespace LogicProject.Challenges
{
    internal class Challenges03
    {
        //public static void Challenge01(int n = 5)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= n; j++)
        //        {
        //            if (i % 2 == 1)
        //            {
        //                // For odd numbered rows print descending numbers (n to 1)
        //                Console.Write("{0} ", n - j + 1);
        //            }
        //            else
        //            {
        //                // For even numbered rows print ascending numbers (1 to n)
        //                Console.Write("{0} ", j);
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}

        public static void ShowPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 == 1)
                    {
                        // Print dari nilai n ke 1
                        Console.Write("{0} ", n - j + 1);
                    }
                    else
                    {
                        // Prnt dari nilai 1 ke n
                        Console.Write("{0} ", j);
                    }
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void Challenge02(int n = 5)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 == 1)
                    {
                        // For odd numbered rows print descending numbers (n to 1)
                        Console.Write("{0} ", n - j + 1);
                    }
                    else
                    {
                        // For even numbered rows print ascending numbers (1 to n)
                        Console.Write("{0} ", j);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
