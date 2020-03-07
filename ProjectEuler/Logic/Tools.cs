using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Logic
{
    public static class Tools
    {
        public static bool IsPrime(int t)
        {
            for (int i = 2; i < t / 2 + 1; i++)
            {
                if (t % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static long GetFactorial(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        public static string GetStringFactorial(int n)
        {
            string res = "1";
            for (int i = 2; i <= n; i++)
            {
                res = BigMathMultiplication(res, i.ToString());
            }
            return res;
        }
        public static string BigMathMultiplication(string s1, string s2)
        {
            if (s1.Length < s2.Length)
            {
                string t = s1;
                s1 = s2;
                s2 = t;
            }
            string summ = "0";
            for (int j = s2.Length; j > 0; j--)
            {
                string res;
                string r = string.Empty;
                int n = 0;
                int f = 0;
                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    n = Convert.ToInt32(char.GetNumericValue(s1[i])) * Convert.ToInt32(char.GetNumericValue(s2[j - 1])) + f;
                    int p = n % 10;
                    r += p.ToString();
                    f = n / 10;
                }
                char[] arr = r.ToCharArray();
                Array.Reverse(arr);
                if (f == 0)
                {
                    res = new string(arr);
                }
                else
                {
                    res = f + new string(arr);
                }
                if (s2.Length == 1)
                {
                    return res;
                }
                //else if (res.Length > 1 && res.StartsWith("0"))
                //{
                    //summ = res + "0";
                //}
                //else
                // {
                    summ = BigMathSum(summ, res);
                //}
                
            }
            return summ;
        }
        public static string BigMathSum(string s1, string s2)
        {
            if (s1 == "0" && s2 != "0")
            {
                return s2;
            }
            if (s1 != "0" && s2 == "0")
            {
                return s1;
            }
            int q = s1.Length - s2.Length;
            if (q > 0)
            {
                for (int i = 0; i < q; i++)
                {
                    s2 = "0" + s2;
                }
            }
            string r = string.Empty;
            int n = 0;
            int f = 0;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                n = Convert.ToInt32(char.GetNumericValue(s1[i])) + Convert.ToInt32(char.GetNumericValue(s2[i])) + f;
                int p = n % 10;
                r += p.ToString();
                f = n / 10;
            }
            char[] arr = r.ToCharArray();
            Array.Reverse(arr);
            if (f == 0)
            {
                return new string(arr);
            }
            return f + new string(arr);
        }

        public static string BigMathMiltiplicationBy2(string t)
        {
            char[] A = t.ToCharArray();
            StringBuilder res = new StringBuilder();
            int p = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                int x = (int)char.GetNumericValue(A[i]) * 2 + p;
                res.Append(x % 10);
                p = x / 10;
            }
            if (p > 0)
            {
                res.Append(p);
            }
            char[] charArray = res.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
