using System;

namespace LogicProject.Challenges
{
    internal class Challenges04
    {
        public static void Challenge01(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 == 1)
                    {
                        // For odd rows: print "- 2 - 4 - 6 - 8 -"
                        if (j % 2 == 1)
                        {
                            Console.Write("- ");
                        }
                        else
                        {
                            Console.Write("{0} ", j);
                        }
                    }
                    else
                    {
                        // For even rows: print "1 - 3 - 5 - 7 - 9"
                        if (j % 2 == 0)
                        {
                            Console.Write("- ");
                        }
                        else
                        {
                            Console.Write("{0} ", j);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void Challenge02(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % 2 == 1)
                    {
                        // For odd rows: print "- 2 - 4 -"
                        if (j % 2 == 1)
                        {
                            Console.Write("- ");
                        }
                        else
                        {
                            Console.Write("{0} ", j);
                        }
                    }
                    else
                    {
                        // For even rows: print "1 - 3 - 5"
                        if (j % 2 == 0)
                        {
                            Console.Write("- ");
                        }
                        else
                        {
                            Console.Write("{0} ", j);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
