using System;
using System.Threading;

namespace Lab21
{
    class Program
    {
        const int n = 35;
        static int[,] array = new int[n, n];

        static void Main(string[] args)
        {

            //Console.WriteLine("Введите размеры участка земли");
            //int n = Convert.ToInt32(Console.ReadLine());
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardener2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static public void Gardener1()
        {
            for (int i = 0; i < n; i = i + 2)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < 0)
                    {
                        continue;
                    }
                    else
                    {
                        array[i, j] = -1;
                    }
                }
            }

            for (int i = 1; i < n; i = i + 2)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (array[i, j] < 0)
                    {
                        continue;
                    }
                    else
                    {
                        array[i, j] = -1;
                    }
                }
            }
        }
        static public void Gardener2()
        {
            for (int j = n - 1; j >= 0; j=j-2)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (array[i, j] < 0)
                    {
                        continue;
                    }
                    else
                    {
                        array[i, j] = -2;
                    }
                }
            }

            for (int j = n - 2; j >= 0; j = j - 2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i, j] < 0)
                    {
                        continue;
                    }
                    else
                    {
                        array[i, j] = -2;
                    }
                }
            }
        }
    }

}



