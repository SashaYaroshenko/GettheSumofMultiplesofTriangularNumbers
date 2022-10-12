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
        }
    }
    public static class Kata
    {
        public static BigInteger SumMultTriangNum(int n, int m)
        {
            List<int> progression1 = new List<int>();
            List<BigInteger> progression2 = new List<BigInteger>();
            int count = 0;
            int multipl = 0;
            BigInteger sum = 0;
            for (int i = 1; i <= n; i++)
            {
                progression1.Add(i * (i + 1) / 2);
            }
            for (int i = 1; i < int.MaxValue; i++)
            {
                count = 0;
                for (int p = 0; p < progression1.Count; p++)
                {
                    if (progression1.Max() * i % progression1[p] == 0)
                    {

                        count++;

                    }
                }
                if (count == progression1.Count)
                {
                    multipl = progression1.Max() * i;
                    break;
                }
            }
            //while(progression2.Count!=m)
            {
                for (int i = 1; i <= m; i++)
                {
                    progression2.Add(multipl * i);
                }
            }
            for (int i = 0; i < progression2.Count; i++)
            {
                sum += progression2[i];
            }
            return sum;

        }
    }
}
