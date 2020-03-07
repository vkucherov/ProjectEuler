using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class _10001st_prime : iTask
    {
        const int N = 10001;
        int res;
        public _10001st_prime()
        {
            calculate();
        }

        private void calculate()
        {
            int j = 0;
            for (int i = 2; i < int.MaxValue; i++)
            {
                if (Tools.IsPrime(i))
                {
                    j++;
                    if (j == N)
                    {
                        res = i;
                        break;
                    }
                }
            }
        }

        public void Result()
        {
            Console.WriteLine(res);
        }
    }
}
