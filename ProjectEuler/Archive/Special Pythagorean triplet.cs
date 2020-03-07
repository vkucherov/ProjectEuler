using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Special_Pythagorean_triplet : BasicTask
    {
        const int N = 1000;
        public Special_Pythagorean_triplet()
        {
            bool found = false;
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    for (int p = 1; p < N; p++)
                    {
                        if (i * i + j * j == p * p && i + j + p == N)
                        {
                            base.Res = i * j * p;
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
        }
    }
}
