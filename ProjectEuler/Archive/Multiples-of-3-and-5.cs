using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Multiples_of_3_and_5 : iTask
    {
        int Limit;

        List<int> Numbers;

        public Multiples_of_3_and_5() : this (1000)
        {
            
        }

        public Multiples_of_3_and_5(int limit)
        {
            Limit = limit;
            Numbers = new List<int>();

            for (int i = 3; i < Limit; i++)
            {
                if (i % 3 == 0 || i %5 == 0)
                {
                    Numbers.Add(i);
                }
            }
        }

        public void OutputNumbers()
        {
            Console.Write("Numbers: ");
            foreach (var item in Numbers)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        public void GetSum()
        {
            Console.WriteLine("Sum: ");
            int sum = 0;
            foreach (var item in Numbers)
            {
                sum += item;
            }
            Console.WriteLine(sum.ToString());
        }

        public void Result()
        {
            this.OutputNumbers();
            this.GetSum();
        }
    }
}
