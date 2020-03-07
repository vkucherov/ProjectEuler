using ProjectEuler.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Archive
{
    public class Largest_prime_factor : iTask
    {
        long a;

        //List<long> Primes = new List<long>();
        //List<long> Factors = new List<long>();

        //600851475143
        public Largest_prime_factor() : this(600851475143)
        {
            
        }

        public Largest_prime_factor(long l)
        {
            a = l;
            fillFactors();
        }

        private void fillFactors()
        {
            for (long i = a / 2 + 1; i > 0; i--)
            {
                //Console.WriteLine(i.ToString());
                if (a % i == 0)
                {
                    Console.WriteLine("Factor: " + i.ToString());
                    if (isPrime(i))
                    {
                        Console.WriteLine("!!!! Prime: " + i.ToString());
                        break;
                    }
                }
                
            }
        }

        public void Result()
        {
            //foreach (var item in Primes)
            //{
            //    //Console.WriteLine(item.ToString());
            //}
        }

        //void fillPrimes()
        //{
        //    for (Int64 i = a; i > 1; i--)
        //    {
        //        Console.WriteLine(i.ToString());
        //        bool t = isPrime(i);
        //        if (t && a % i == 0)
        //        {
        //            Primes.Add(i);
        //            Console.WriteLine("!!!!" + i.ToString());
        //        }
                
        //    }
         
        //}

        private bool isPrime(long t)
        {
            for (int i = 2; i < t / 2 + 1; i++)
            {
                if (t % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
