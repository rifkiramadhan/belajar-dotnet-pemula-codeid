using System;
using System.Threading;

namespace LogicProject.Practice.Practice01
{
    internal class Looping
    {
        public static void DrawBox()
        {
            int milliseconds = 200;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
        }

        // Console Class
        public static void ConsoleClass()
        {
            // 01. Simple Write
            Console.Write("Code id Bootcamp");


            // 02. Simple WriteLine with concat
            Console.WriteLine("Code Academy " + " Bootcamp .Net");

            Console.WriteLine("Code Academy \nCool .Net");

            // 03 Quote
            Console.WriteLine("I love Programming \"C#\"");

            // 04. Verbatim
            Console.WriteLine(@"Bootcamp .Net With Codeid Academy Lokasi Sentul City Bogor Indonesia");

            // 05. Formatting Parameter
            Console.WriteLine("Temperature di Bogor tanggal {0} suhu {1} celcius", DateTime.Today, 20.0);

        }

        public static void TriangleOne()
        {

            int milliseconds = 200;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
        }

        public static void TriangleTwo()
        {
            int n = 5;
            int milliseconds = 200;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Thread.Sleep(milliseconds);
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void TriangleThree()
        {
            int n = 5;
            int milliseconds = 5;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Thread.Sleep(milliseconds);
                    if (j < i)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        public static void TriangleFour()
        {
            int n = 5;
            int milliseconds = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Thread.Sleep(milliseconds);
                    if (j < n - i)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
