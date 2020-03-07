using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Logic
{
    public static class DigitsToWords
    {
        public static string GetWords(int n)
        {
            if (n >= 0 && n <= 9)
            {
                return getFromZeroToNine(n);
            }
            if (n >= 11 && n <= 19)
            {
                return getFromElevenToNineteen(n);
            }
            if (n % 10 == 0 && 0 < n && n < 100)
            {
                return getTens(n);
            }
            if (n > 20 && n < 100)
            {
                return getTens(n / 10 * 10) + "-" + getFromZeroToNine(n % 10);
            }
            if (n % 100 == 0 && 99 < n && n < 1000)
            {
                return getHundreds(n);
            }
            if (n > 100 && n < 1000)
            {
                return getHundreds(n / 100 * 100) + " and " + GetWords(n % 100);
            }
            if (n == 1000)
            {
                return "one thousand";
            }
            return "no options";
        }

        private static string getHundreds(int n)
        {
            switch (n)
            {
                case 100:
                    return "one hundred";
                case 200:
                    return "two hundred";
                case 300:
                    return "three hundred";
                case 400:
                    return "four hundred";
                case 500:
                    return "five hundred";
                case 600:
                    return "six hundred";
                case 700:
                    return "seven hundred";
                case 800:
                    return "eight hundred";
                case 900:
                    return "nine hundred";
                default:
                    throw new Exception("Wrong input");
            }
        }

        private static string getFromElevenToNineteen(int n)
        {
            switch (n)
            {
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    throw new Exception("Wrong input");
            }
        }

        private static string getFromZeroToNine(int n)
        {
            switch (n)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new Exception("Wrong input");
            }
        }

        private static string getTens(int n)
        {
            switch (n)
            {
                case 10:
                    return "ten";
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "forty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
                default:
                    throw new Exception("Wrong input");
            }
        }
    }
}
