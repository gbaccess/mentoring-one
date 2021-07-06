using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

// WRite Test Cases for divisible by three, divisible by 5 and divisible by both

namespace MentoringOne.Test
{
    public class FizzBuzzTests
    {
        //[TestCase(1, "1")]
        //[TestCase(2, "2")]
        //[TestCase(3, "fizz")]
        //[TestCase(4, "4")]
        //[TestCase(6, "fizz")]
        [Test]
        public void if_number_is_multiple_of_three_prints_fizz()
        {
            // given
            var subject = new FizzBuzz();
            for (int num = 0; num < 101; num++)
            {
                var divisibleByThree = num % 3 == 0;
                // when
                var result = subject.Calculate(num);

                // then
                if (divisibleByThree)
                {
                    Assert.AreEqual("fizz", result);
                }
                else
                {
                    Assert.AreNotEqual("fizz", result);
                }

            }
        }

        [Test]
        public void if_number_is_divisible_by_five_prints_buzz()
        {
            // given
            var subject = new FizzBuzz();
            for (int num = 0; num < 101; num++)
            {
                var divisibleByFive = num % 5 == 0;
                // when
                var result = subject.Calculate(num);

                // then
                if (divisibleByFive)
                {
                    Assert.AreEqual("buzz", result);
                }
                else
                {
                    Assert.AreNotEqual("buzz", result);
                }
            }

        }
    }

    public class FizzBuzz
    {
        public string Calculate(int num)
        {
            var divisibleByThree = num % 3 == 0;
            var divisibleByFive = num % 5 == 0;
            if (divisibleByThree && !divisibleByFive)
            {
                return "fizz";
            }
            
            if (divisibleByFive)
            {
                return "buzz";
            }
            return num.ToString();
        }
    }
}
