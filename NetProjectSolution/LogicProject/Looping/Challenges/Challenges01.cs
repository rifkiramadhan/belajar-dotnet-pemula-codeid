using System;
using System.Threading;

namespace LogicProject.Challenge
{
    internal class Challenges01
    {
        public static void Challenge01()
        {
            int milliseconds = 200;
            int count = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Thread.Sleep(milliseconds);

                    Console.Write("{0} ", count);
                    count++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void Challenge02()
        {
            int milliseconds = 200;
            int count = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write("{0} ", count + j);
                }
                count++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void Challenge03()
        {
            int milliseconds = 200;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static void Challenge04()
        {
            int milliseconds = 200;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 0 + i; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write("  ");
                }

                for (int j = i; j <= 5; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
