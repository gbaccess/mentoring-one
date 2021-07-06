using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

// WRite Test Cases for divisible by three, divisible by 5 and divisible by both

namespace MentoringOne.Test
{
    public class FizzBuzzTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(15)]
        [TestCase(18)]
        [TestCase(21)]
        [TestCase(24)]
        [TestCase(27)]
        [TestCase(33)]
        [TestCase(36)]
        [TestCase(39)]
        [TestCase(42)]
        [TestCase(48)]
        public void returns_fizz_when_multiple_of_three(int value)
        {
            // given
            var subject = new FizzBuzzService();

            // when
            var result = subject.Get(value);

            // then
            Assert.AreEqual("Fizz", result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(35)]
        [TestCase(40)]
        [TestCase(50)]
        public void returns_buzz_multiple_five(int value)
        {
            // given
            var subject = new FizzBuzzService();

            // when
            var result = subject.Get(value);

            // then
            Assert.AreEqual("Buzz", result);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void returns_fizz_buzz_when_muliple_of_five_and_three(int value)
        {
            // given
            var subject = new FizzBuzzService();

            // when
            var result = subject.Get(value);

            // then
            Assert.AreEqual("FizzBuzz", result);
        }
    }

    public class FizzBuzzService
    {
        public string Get(int value)
        {
            if (value % 3 == 0)
            {
                return "Fizz";
            }

            return "Buzz";
        }
    }
}
