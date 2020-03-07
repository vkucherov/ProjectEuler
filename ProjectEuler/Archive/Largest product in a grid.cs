using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Largest_product_in_a_grid : BasicTask
    {
        int[,] X = new int[20, 20];
        long res = 1;
        const int N = 4;
        public Largest_product_in_a_grid()
        {
            fillX();
            findMaxMovingRight();
            findMaxMovingDown();
            findMaxMovingDiagonally();
            findMaxMovingDiagonally2();
        }

        private void findMaxMovingDiagonally2()
        {
            for (int i = X.GetLength(1) - N; i >= 0; i--)
            {
                for (int j = 0; j < X.GetLength(0) - N; j++)
                {
                    for (int p = 0; p < N; p++)
                    {
                        res *= X[i + p, j + p];
                    }
                    if (base.Res < res)
                    {
                        base.Res = res;
                    }
                    res = 1;
                }
            }
        }

        private void findMaxMovingDiagonally()
        {
            for (int i = X.GetLength(0) - 1; i >= N - 1; i--)
            {
                for (int j = X.GetLength(1) - N; j >= 0; j--)
                {
                    for (int p = 0; p < N; p++)
                    {
                        res *= X[i - p, j + p];
                    }
                    if (base.Res < res)
                    {
                        base.Res = res;
                    }
                    res = 1;
                }
            }
        }

        private void findMaxMovingDown()
        {
            for (int i = 0; i < X.GetLength(1); i++)
            {
                for (int j = 0; j < X.GetLength(0) - N + 1; j++)
                {
                    for (int p = 0; p < N; p++)
                    {
                        res *= X[j + p, i];
                    }
                    if (base.Res < res)
                    {
                        base.Res = res;
                    }
                    res = 1;
                }
            }
        }

        private void findMaxMovingRight()
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1) - N + 1; j++)
                {
                    for (int p = 0; p < N; p++)
                    {
                        res *= X[i, j + p];
                    }
                    if (base.Res < res)
                    {
                        base.Res = res;
                    }
                    res = 1;
                }
            }
        }

        private void fillX()
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Data\Largest product in a grid.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    X[i, j] = Convert.ToInt32(numbers[j]);
                }
            }
        }

        private void outputX()
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write(X[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
