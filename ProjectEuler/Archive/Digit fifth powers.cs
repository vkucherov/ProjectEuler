using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Digit_fifth_powers : BasicTask
    {
        const int N = 5;
        const int START = 10;
        private long finish;
        public Digit_fifth_powers()
        {
            calcFinish();
            for (int i = START; i <= finish; i++)
            {
                int sum = 0;
                string s = i.ToString();
                foreach (var item in s)
                {
                    sum += calcPower(item);
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                    base.Res += sum;
                }
            }
        }

        private int calcPower(char item)
        {
            int a = Convert.ToInt32(char.GetNumericValue(item));
            int res = a;
            for (int i = 1; i < N; i++)
            {
                res *= a;
            }
            return res;
        }

        private void calcFinish()
        {
            long res = 9;
            for (int i = 1; i < N; i++)
            {
                res *= 9;
            }
            finish = res * N;
        }
    }
}
