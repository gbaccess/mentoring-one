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
        [TestCase(30)]
        [TestCase(33)]
        [TestCase(36)]
        [TestCase(39)]
        [TestCase(42)]
        [TestCase(45)]
        [TestCase(48)]
        public void returns_fizz(int value)
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
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(30)]
        [TestCase(35)]
        [TestCase(40)]
        [TestCase(45)]
        [TestCase(50)]
        public void returns_buzz(int value)
        {
            // given
            var subject = new FizzBuzzService();

            // when
            var result = subject.Get(value);

            // then
            Assert.AreEqual("Buzz", result);
        }

    }

    public class FizzBuzzService
    {
        public string Get(int value)
        {
            return "Fizz";
        }
    }
}
