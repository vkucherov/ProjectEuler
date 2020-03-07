using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Power_digit_sum : BasicTask
    {
        public Power_digit_sum()
        {
            string t = "2";
            for (int i = 2; i <= 1000; i++)
            {
                t = Tools.BigMathMiltiplicationBy2(t);
            }
            Console.WriteLine(t);
            foreach (var item in t)
            {
                base.Res += (int)char.GetNumericValue(item);
            }
        }
    }
}
