using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Lattice_paths : BasicTask
    {
        int N = 20;
        long t = 0;
        public Lattice_paths()
        {
            go(0, 0);
            base.Res = t;
        }

        void go(int i, int j)
        {
            //if (isFinish(i, j))
            if (i == 20 && j == 20)
            {
                t++;
            }
            else
            {
                //if (canGoRight(i))
                if (i < 20)
                {
                    go(i + 1, j);
                }
                //if (canGoDown(j))
                if (j < 20)
                {
                    go(i, j + 1);
                }
            }
        }

        private bool canGoRight(int i)
        {
            return i < N;
        }

        private bool canGoDown(int j)
        {
            return j < N;
        }

        private bool isFinish(int i, int j)
        {
            return i == N && j == N;
        }
    }
}
