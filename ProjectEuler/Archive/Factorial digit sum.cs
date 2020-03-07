using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Factorial_digit_sum : BasicTask
    {
        const int N = 11;
        public Factorial_digit_sum()
        {
            Console.WriteLine(Tools.GetStringFactorial(N));
        }
    }
}
