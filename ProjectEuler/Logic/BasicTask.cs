using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Logic
{
    public abstract class BasicTask : iTask
    {
        protected long Res;

        public void Result()
        {
            Console.WriteLine("The answer is " + Res);
        }

    }
}
