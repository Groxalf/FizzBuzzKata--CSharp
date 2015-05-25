using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Com.Miguel.FizzBuzzKata.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a_5_element_string_should_contain_fizz_buzz_when_the_number_is_divisible_by_two_or_three()
        {
            Assert.AreEqual("1\nFizz\nBuzz\nFizz\n5", FizzBuzzGenerator.GetChain(5));

        }
    }
}
