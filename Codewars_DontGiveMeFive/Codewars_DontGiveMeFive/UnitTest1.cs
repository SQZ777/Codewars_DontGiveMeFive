using System;
using System.Linq;
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

        [TestMethod]
        public void Input_9_And_10_Should_Be_2()
        {
            GetDontGiveMeFiveResult(2, 9, 10);
        }

        [TestMethod]
        public void Input_1_And_9_Should_Be_8()
        {
            GetDontGiveMeFiveResult(8, 1, 9);
        }
        [TestMethod]
        public void Input_4_And_17_Should_Be_12()
        {
            GetDontGiveMeFiveResult(12, 4, 17);
        }

        [TestMethod]
        public void Input_0_And_60_Should_Be_46()
        {
            GetDontGiveMeFiveResult(46, 0, 60);

        }


        [TestMethod]
        public void Input_N5_And_0_Should_Be_5()
        {
            GetDontGiveMeFiveResult(5, -5, 0);
        }

        [TestMethod]
        public void Input_N55_And_N45_Should_Be_4()
        {
            GetDontGiveMeFiveResult(4, -55, -45);
        }

        [TestMethod]
        public void Input_500_And_600_Should_Be_1()
        {
            GetDontGiveMeFiveResult(1, 500, 600);
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
            for (var i = start; i <= end; i++)
                if (!i.ToString().Contains("5"))
                    result++;
            return result;
        }

    }
}
