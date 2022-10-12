using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.SumMultTriangNum(5, 8);
        }
    }
    public static class Kata
    {
        public static BigInteger SumMultTriangNum(int n, int m)
        {
            BigInteger[] progression1 = new BigInteger[n];
            BigInteger[] progression2 = new BigInteger[m];
            BigInteger multipl = 0;
            BigInteger sum = 0;

            for (int i = 1; i <= n; i++)
            {
                progression1[i - 1] = i * (i + 1) / 2;
            }

            // https://www.w3resource.com/csharp-exercises/math/csharp-math-exercise-20.php
            multipl = gcdFind(progression1);

            for (int i = 1; i <= m; i++)
            {
                progression2[i - 1] = multipl * i;
            }

            for (int i = 0; i < progression2.Length; i++)
            {
                sum += progression2[i];
            }
            return sum;

        }

        static BigInteger gcd(BigInteger n1, BigInteger n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }

        static BigInteger gcdFind(BigInteger[] numbers)
        {
            return numbers.Aggregate((S, val) => S * val / gcd(S, val));
        }
    }
}