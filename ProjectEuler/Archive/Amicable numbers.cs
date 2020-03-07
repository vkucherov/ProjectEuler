using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Amicable_numbers : BasicTask
    {
        public Amicable_numbers()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                int a = d(i);
                if (d(a) == i && a != i && !list.Contains(a))
                {
                    list.Add(a);
                    list.Add(i);
                }
            }

            foreach (var item in list)
            {
                base.Res += item;
            }
        }

        protected int d(int a)
        {
            int r = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    r += i;
                }
            }
            return r;
        }
    }
}
