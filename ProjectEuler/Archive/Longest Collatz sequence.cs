using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Longest_Collatz_sequence : BasicTask
    {
        const int N = 999999;
        public Longest_Collatz_sequence()
        {
            long longest = 0;
            long temp = 0;
            for (int i = N; i >1; i--)
            {
                temp = calcChainAmount(i);
                //Console.WriteLine("Chain items: " + temp + ". i = " + i);
                if (longest < temp)
                {
                    longest = temp;
                    Console.WriteLine("!!!!! The longest: " + longest + ". i = " + i);
                    base.Res = i;
                }
                if (i % 10000 == 0)
                {
                    Console.WriteLine("*** i = " + i);
                }
            }
        }

        long calcChainAmount(long q)
        {
            long t = 1;
            long p = q;
            while (p != 1)
            {
                if (isEven(p))
                {
                    p = p / 2;
                }
                else
                {
                    p = p * 3 + 1;
                }
                t++;
            }
            return t;
        }
        private bool isEven(long i)
        {
            return i % 2 == 0;
        }
    }
}
