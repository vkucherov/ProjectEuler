using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Smallest_multiple : iTask
    {
        const int N = 20;
        private int res = -1;
        public void Result()
        {
            calculateRes();
            Console.WriteLine(res.ToString());
        }

        private void calculateRes()
        {
            for (int i = N; i < int.MaxValue; i++)
            {
                bool b = false;
                for (int j = 2; j < N; j++)
                {
                    if (i % j != 0)
                    {
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    res = i;
                    break;
                }
            }
        }
    }
}
