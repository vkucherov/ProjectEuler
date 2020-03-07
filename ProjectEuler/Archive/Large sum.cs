using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Large_sum : BasicTask
    {
        string res = string.Empty;
        public Large_sum()
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Data\Large sum.txt");
            string temp = sum(lines[0], lines[1]);
            for (int i = 2; i < lines.Length; i++)
            {
                temp = sum(temp, lines[i]);
                Console.WriteLine(temp);
            }
            string t = temp.Substring(0, 10);
            long r = Convert.ToInt64(t);
            base.Res = r;
        }

        string sum(string s1, string s2)
        {
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
    }
}
