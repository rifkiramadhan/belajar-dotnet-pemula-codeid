using System;
using System.Threading;

namespace LogicProject.Challenges
{
    internal class Challenges02
    {
        public static void Challenge01()
        {
            int milliseconds = 200;
            int leftValue = 20;
            int rightValue = 10;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Thread.Sleep(milliseconds);

                    if (j < i)
                    {
                        Console.Write("{0} ", leftValue);
                    }
                    else if (j == i)
                    {
                        Console.Write("{0} ", i);
                    }
                    else
                    {
                        Console.Write("{0} ", rightValue);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void Challenge02()
        {
            int milliseconds = 200;
            int leftValue = 10;
            int centerValue = 6;
            int rightValue = 20;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Thread.Sleep(milliseconds);

                    if (j < i)
                    {
                        Console.Write("{0} ", leftValue);
                    }
                    else if (j == i)
                    {
                        Console.Write("{0} ", centerValue - i);
                    }
                    else
                    {
                        Console.Write("{0} ", rightValue);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        //public static void Challenge03()
        //{
        //    Console.Write("Input jumlah baris piramid: ");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine();

        //    for (int i = n; i >= 1; i--)
        //    {
        //        // Print descending dari i sampai 1
        //        for (int j = i; j >= 1; j--)
        //        {
        //            Console.Write("{0} ", j);
        //        }

        //        // Print ascending dari 2 sampai i
        //        for (int j = 2; j <= i; j++)
        //        {
        //            Console.Write("{0} ", j);
        //        }

        //        Console.WriteLine();
        //    }

        //    Console.ReadKey();
        //}

        public static void Challenge03()
        {
            Console.Write("Input jumlah baris piramid: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = n; i >= 1; i--)
            {
                // Ngeprint descending dari i sampai 1
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("{0} ", j);
                }

                // Ngeprint ascending dari 2 sampai i
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }

            // Agar console tidak keluar automatice
            Console.ReadKey();
        }

        public static void Challenge04()
        {
            Console.WriteLine("PrimeNumber");

            // Print initial sequence 0-4
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // Print prime numbers
            int [] primes = new int[5];
            int primeCount = 0;
            int number = 2;

            while (primeCount < 5)
            {
                // Prime checking logic
                if (number == 2)
                {
                    primes[primeCount] = number;
                    primeCount++;
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        primes[primeCount] = number;
                        primeCount++;
                    }
                }
                number++;
            }

            // Print prime numbers
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }

            Console.WriteLine();
        }
    }
}
