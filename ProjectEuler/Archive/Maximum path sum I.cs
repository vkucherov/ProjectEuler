using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Maximum_path_sum_I : BasicTask
    {
        int[,] numbers;
        //int sum;
        public Maximum_path_sum_I()
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Data\Maximum path sum I.txt");
            //string[] lines = System.IO.File.ReadAllLines(@".\Data\Maximum path sum I - 2.txt");

            numbers = new int[lines.Length, lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(" ");
                for (int j = 0; j < temp.Length; j++)
                {
                    numbers[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            addNext(0, 0);
        }

        private void addNext(int a, int b)
        {
            int d = numbers[a, b];
            int sum = 0;
            sum += d;
            checkIfCanAdd(a, b, sum);
        }

        private void checkIfCanAdd(int a, int b, int sum)
        {
            if (a < numbers.GetLength(0) - 1)
            {
                addNext(a + 1, b);
                addNext(a + 1, b + 1);
            }
            else
            {
                if (base.Res < sum)
                {
                    base.Res = sum;
                }
                sum = 0;
            }
        }
    }
}
