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
            //arrange
            var start = 0;
            var end = 1;
            var expected = 2;
            //act
            var actual = Kata.DontGiveMeFive(start, end);
            //assert
            Assert.AreEqual(expected, actual);


        }
    }

    public class Kata
    {
        public static int DontGiveMeFive(int start, int end)
        {
            var result = 0;
            for (int i = start; i <= end; i++)
                result++;
            return result;
        }
    }
}
