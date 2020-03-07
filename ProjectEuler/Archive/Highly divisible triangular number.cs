using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Highly_divisible_triangular_number : BasicTask
    {
        //long[] seq = new long[N];
        List<long> seq = new List<long>();
        const int N = 1000000000;
        const int R = 500;
        public Highly_divisible_triangular_number()
        {
            long p = 0;
            for (int i = 1; i <= N; i++)
            {
                p += i;
                //seq[i - 1] = p;
                seq.Add(p);
            }

            for (int i = 0; i < N; i++)
            {
                int q = 0;
                List<int> e = new List<int>();
                for (int j = 1; j < N; j++)
                {
                    if (seq[i] % j == 0)
                    {
                        q++;
                        e.Add(j);
                    }
                    if (seq[i] < j)
                    {
                        Console.Write(seq[i] + ": " + e.Count);
                        //foreach (var item in e)
                        //{
                        //    Console.Write(item + ", ");
                            
                        //}
                        Console.WriteLine();
                        break;
                    }
                }
                if (q >= R)
                {
                    base.Res = seq[i];
                    break;
                }
            }
        }
    }
}
