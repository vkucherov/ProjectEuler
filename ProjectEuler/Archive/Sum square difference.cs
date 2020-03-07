using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Sum_square_difference : iTask
    {
        const int N = 100;
        int Sum1, Sum2 = 0;
        public Sum_square_difference()
        {
            calculate();
        }

        private void calculate()
        {
            for (int i = 1; i <= N; i++)
            {
                Sum1 += i * i;
                Sum2 += i;
            }
            Sum2 = Sum2 * Sum2;
        }

        public void Result()
        {
            Console.WriteLine(Sum2 - Sum1);
        }
    }
}
