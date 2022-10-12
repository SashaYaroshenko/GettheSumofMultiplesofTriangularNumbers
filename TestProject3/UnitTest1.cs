namespace Solution
{
    using ConsoleApp1;
    using NUnit.Framework;
    using System;
    using System.Numerics;
    using BigInt = System.Numerics.BigInteger;

    [TestFixture]
    public class SolutionTest
    {
        static void Act(BigInt expected, int n, int m)
          => Assert.AreEqual(expected, Kata.SumMultTriangNum(n, m), $"\n  n = {n}\n  m = {m}\n");

        [TestCase(1080, 5, 8)]
        [TestCase(23100, 7, 10)]
        [TestCase(1663200, 10, 15)]
        public void FixedTests(int expected, int n, int m) => Act(expected, n, m);

    }
}