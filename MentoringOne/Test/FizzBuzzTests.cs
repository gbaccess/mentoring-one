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

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(16)]
        [TestCase(19)]
        [TestCase(22)]
        [TestCase(23)]
        [TestCase(26)]
        [TestCase(28)]
        [TestCase(29)]
        [TestCase(31)]
        [TestCase(32)]
        [TestCase(34)]
        [TestCase(37)]
        [TestCase(38)]
        [TestCase(41)]
        [TestCase(43)]
        [TestCase(44)]
        [TestCase(46)]
        [TestCase(47)]
        [TestCase(49)]
        public void returns_number_string_when_not_multiple_of_five_or_three(int value)
        {
            // given
            var subject = new FizzBuzzService();

            // when
            var result = subject.Get(value);

            // then
            Assert.AreEqual(value.ToString(), result);
        }
    }

    public class FizzBuzzService
    {
        public string Get(int value)
        {
            if (DivisbleByThree(value) && DivisbleByFive(value))
            {
                return "FizzBuzz";
            }

            if (DivisbleByThree(value))
            {
                return "Fizz";
            }

            if (DivisbleByFive(value))
            {
                return "Buzz";
            }

            return value.ToString();
        }

        private bool DivisbleByThree(int value) => value % 3 == 0;
        private bool DivisbleByFive(int value) => value % 5 == 0;
    }
}
