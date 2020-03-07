using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Names_scores : BasicTask
    {
        public Names_scores()
        {
            string line = System.IO.File.ReadAllText(@".\Data\p022_names.txt");
            string[] list = line.Replace("\"", "").Split(",");
            List<string> names = new List<string>();
            for (int i = 0; i < list.Length; i++)
            {
                names.Add(list[i]);
            }
            names.Sort();
            List<int> values = new List<int>();
            for (int i = 1; i <= names.Count; i++)
            {
                int r = calculateValue(names[i - 1]) * i;
                values.Add(r);
                Console.WriteLine(names[i - 1] + " " + r);
                base.Res += r;
            }
        }

        private int calculateValue(string item)
        {
            int r = 0;
            for (int i = 0; i < item.Length; i++)
            {
                char c = item[i];
                r += getValue(c);
            }
            return r;
        }

        private int getValue(char c)
        {
            switch (c)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 5;
                case 'F':
                    return 6;
                case 'G':
                    return 7;
                case 'H':
                    return 8;
                case 'I':
                    return 9;
                case 'J':
                    return 10;
                case 'K':
                    return 11;
                case 'L':
                    return 12;
                case 'M':
                    return 13;
                case 'N':
                    return 14;
                case 'O':
                    return 15;
                case 'P':
                    return 16;
                case 'Q':
                    return 17;
                case 'R':
                    return 18;
                case 'S':
                    return 19;
                case 'T':
                    return 20;
                case 'U':
                    return 21;
                case 'V':
                    return 22;
                case 'W':
                    return 23;
                case 'X':
                    return 24;
                case 'Y':
                    return 25;
                case 'Z':
                    return 26;
                default:
                    throw new Exception();
            }
        }
    }
}
