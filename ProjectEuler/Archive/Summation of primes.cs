using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Summation_of_primes : BasicTask
    {
        const int N = 2000000;
        public Summation_of_primes()
        {
            for (int i = 2; i < N; i++)
            {
                if (Logic.Tools.IsPrime(i))
                {
                    base.Res += i;
                }
                if (i % 200000 == 0)
                {
                    Console.WriteLine("+ 10% done");
                }
            }
        }
    }
}
