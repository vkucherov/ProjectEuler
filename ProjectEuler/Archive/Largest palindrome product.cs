using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Largest_palindrome_product : iTask
    {
        private int a;
        private int res;
        int limit;
        public Largest_palindrome_product() : this(2) { }
        public Largest_palindrome_product(int a1)
        {
            a = a1;
            calculateLimit();
            calculateResult();
        }

        private void calculateLimit()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                s.Append("9");
            }
            limit = Convert.ToInt32(s.ToString());
        }

        private void calculateResult()
        {
            int r;
            for (int i = limit; i >= 1; i--)
            {
                for (int j = limit; j >= 1; j--)
                {
                    r = i * j;
                    if (isPalindrome(r))
                    {
                        if (r > res)
                        {
                            res = r;
                        }
                    }
                }
            }
        }

        private bool isPalindrome(int r)
        {
            char[] m = r.ToString().ToCharArray();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != m[m.Length - i - 1] && m.Length - i > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public void Result()
        {
            Console.WriteLine("The result is: " + res.ToString());
        }
    }
}
