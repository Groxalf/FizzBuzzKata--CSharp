using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Com.Miguel.FizzBuzzKata.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a_five_element_string_should_contain_fizz_buzz_when_the_number_is_divisible_by_two_or_three()
        {
            Assert.AreEqual("1\nFizz\nBuzz\nFizz\n5", FizzBuzzGenerator.GetChain(5));

        }

        [TestMethod]
        public void a_ten_or_more_element_string_should_contain_fizzbuzz_when_the_number_is_divisible_by_two_and_three()
        {
            Assert.AreEqual("1\nFizz\nBuzz\nFizz\n5\nFizzBuzz\n7\nFizz\nBuzz\nFizz", FizzBuzzGenerator.GetChain(10));

        }
    }
}
