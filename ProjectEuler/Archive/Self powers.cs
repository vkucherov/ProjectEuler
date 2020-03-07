using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Self_powers : BasicTask
    {
        public Self_powers()
        {
            string res = "0";
            for (int i = 1; i <= 10; i++)
            {
                string x = i.ToString();
                for (int j = 1; j < i; j++)
                {
                    x = Tools.BigMathMultiplication(x.ToString(), i.ToString());
                }
                res = Tools.BigMathSum(res, x);
                Console.WriteLine(i + ": " + x);
            }
        }
    }
}
