using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Number_spiral_diagonals : BasicTask
    {
        const int N = 1001;
        private int[,] Matrix;
        public Number_spiral_diagonals()
        {
            initMatrix();
            //outputMatrix();
            base.Res = countDiagonalSum();
        }

        private long countDiagonalSum()
        {
            long res = 0;
            int t = N - 1;
            for (int i = 0; i < N; i++)
            {
                res += Matrix[i, i] + Matrix[i, t];
                t--;
            }
            return res - 1;
        }

        private void outputMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void initMatrix()
        {
            Matrix = new int[N, N];
            fillFromRightToLeft(0, N - 1, N * N);
        }

        private void fillFromRightToLeft(int x, int y, int val)
        {
            for (int j = y; j >= 0; j--)
            {
                if (Matrix[x, j] == 0)
                {
                    Matrix[x, j] = val;
                    val--;
                    y = j;
                }
                else
                {
                    break;
                }
            }
            if (val > 0)
            {
                fillFromTopToBottom(x + 1, y, val);
            }
        }

        private void fillFromTopToBottom(int x, int y, int val)
        {
            for (int i = x; i < N; i++)
            {
                if (Matrix[i, y] == 0)
                {
                    Matrix[i, y] = val;
                    val--;
                    x = i;
                }
                else
                {
                    break;
                }
            }
            if (val > 0)
            {
                fillFromLeftToRight(x, y + 1, val);
            }
        }

        private void fillFromLeftToRight(int x, int y, int val)
        {
            for (int j = y; j < N; j++)
            {
                if (Matrix[x, j] == 0)
                {
                    Matrix[x, j] = val;
                    val--;
                    y = j;
                }
                else
                {
                    break;
                }
            }
            if (val > 0)
            {
                fillFromBottomToTo(x - 1, y, val);
            }
        }

        private void fillFromBottomToTo(int x, int y, int val)
        {
            for (int i = x; i > 0; i--)
            {
                if (Matrix[i, y] == 0)
                {
                    Matrix[i, y] = val;
                    val--;
                    x = i;
                }
                else
                {
                    break;
                }
            }
            if (val > 0)
            {
                fillFromRightToLeft(x, y - 1, val);
            }
        }
    }
}
