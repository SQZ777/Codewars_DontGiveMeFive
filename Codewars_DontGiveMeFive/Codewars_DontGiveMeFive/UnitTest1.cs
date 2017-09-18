using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_DontGiveMeFive
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_And_1_Should_Be_2()
        {
            GetDontGiveMeFiveResult(2, 0, 1);
        }

        [TestMethod]
        public void Input_4_And_5_Should_Be_1()
        {
            GetDontGiveMeFiveResult(1, 4, 5);
        }


        [TestMethod]
        public void Input_14_And_15_Should_Be_1()
        {
            GetDontGiveMeFiveResult(1, 14, 15);
        }

        private static void GetDontGiveMeFiveResult(int expected, int start, int end)
        {
            var actual = Kata.DontGiveMeFive(start, end);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public static int DontGiveMeFive(int start, int end)
        {
            var result = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0 || 10 % i == 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
