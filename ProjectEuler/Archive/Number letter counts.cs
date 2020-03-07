using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Number_letter_counts : BasicTask
    {
        public Number_letter_counts()
        {
            //Console.WriteLine(DigitsToWords.GetWords(0));
            //Console.WriteLine(DigitsToWords.GetWords(4));
            //Console.WriteLine(DigitsToWords.GetWords(9));
            //Console.WriteLine(DigitsToWords.GetWords(10));
            //Console.WriteLine(DigitsToWords.GetWords(15));
            //Console.WriteLine(DigitsToWords.GetWords(20));
            //Console.WriteLine(DigitsToWords.GetWords(26));
            //Console.WriteLine(DigitsToWords.GetWords(50));
            //Console.WriteLine(DigitsToWords.GetWords(72));
            //Console.WriteLine(DigitsToWords.GetWords(99));
            //Console.WriteLine(DigitsToWords.GetWords(100));
            //Console.WriteLine(DigitsToWords.GetWords(119));
            //Console.WriteLine(DigitsToWords.GetWords(-52));
            //Console.WriteLine(DigitsToWords.GetWords(108));
            //Console.WriteLine(DigitsToWords.GetWords(117));
            //Console.WriteLine(DigitsToWords.GetWords(120));
            //Console.WriteLine(DigitsToWords.GetWords(199));
            //Console.WriteLine(DigitsToWords.GetWords(200));
            //Console.WriteLine(DigitsToWords.GetWords(500));
            //Console.WriteLine(DigitsToWords.GetWords(746));
            //Console.WriteLine(DigitsToWords.GetWords(999));
            //Console.WriteLine(DigitsToWords.GetWords(1000));

            string s = "";
            for (int i = 1; i <= 1000; i++)
            {
                s += DigitsToWords.GetWords(i);
            }
            //s = DigitsToWords.GetWords(115);
            Console.WriteLine(s);
            s = s.Replace(" ", "").Replace("-","");
            Console.WriteLine(s);
            base.Res = s.Length;
        }
    }
}
