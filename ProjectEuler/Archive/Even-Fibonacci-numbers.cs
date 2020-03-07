using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Even_Fibonacci_numbers : iTask
    {
        int Limit;
        List<int> List = new List<int>();
        public Even_Fibonacci_numbers(int limit)
        {
            Limit = limit;
            fill();
        }

        public Even_Fibonacci_numbers() : this(4000000) { }

        void fill()
        {
            List.Add(1);
            List.Add(2);
            addNext();
        }

        void addNext()
        {
            int max = List.Count;
            int n1 = List[max - 2];
            int n2 = List[max - 1];
            int n3 = n1 + n2;
            if (n3 < Limit)
            {
                List.Add(n3);
                addNext();
            }
        }

        public void OutputList()
        {
            foreach (var item in List)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Result()
        {
            int sum = 0;
            foreach (var item in List)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
