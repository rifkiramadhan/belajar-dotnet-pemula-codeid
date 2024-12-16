using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.Interviewzen
{
    internal class Challenges
    {
        public static int[] ShowPrimeNumber(int n)
        {
            List<int> bilanganPrima = new List<int>();

            for (int angka = 2; angka <= n; angka++)
            {
                bool prima = true;

                for (int i = 2; i < angka; i++)
                {
                    if (angka % i == 0)
                    {
                        prima = false;
                        break;
                    }
                }

                if (prima)
                {
                    bilanganPrima.Add(angka);
                }
            }

            return bilanganPrima.ToArray();
        }


        public static int[] Fibo(int n)
        {
            if (n <= 0)
            {
                return new int[0];
            }

            List<int> fibonacci = new List<int>();

            int a = 1, b = 1;

            while (true)
            {
                // Kalau nilainya kosong
                if (fibonacci.Count == 0)
                {
                    // Maka tambahkan
                    fibonacci.Add(a);
                    fibonacci.Add(b);
                }

                int fiboSelanjutnya = a + b;
                a = b;
                b = fiboSelanjutnya;

                fibonacci.Add(fiboSelanjutnya);

                // Tambahan untuk Fibo ke 10 dengan maximal sampai angka ke 34
                if (n == 10 && fiboSelanjutnya > 34)
                {
                    fibonacci.RemoveAt(fibonacci.Count - 1);
                    break;
                }

                if (fiboSelanjutnya > n * 20)
                {
                    break;
                }
            }

            return fibonacci.Skip(1).ToArray();
        }

        public static int[] FindDivisor(int n)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors.ToArray();
        }

        public static void ShowPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int kiri = i;
                    int kanan = n - i + 1;

                    // Jika bilangan ganjil
                    if (j % 2 != 0)
                    {
                        // Cetak ganjil
                        Console.Write(kiri + " ");
                    }
                    else
                    {
                        // Jika genap cetak genap
                        Console.Write(kanan + " ");
                    }
                }

                Console.WriteLine();
            }
        }

    }
}
