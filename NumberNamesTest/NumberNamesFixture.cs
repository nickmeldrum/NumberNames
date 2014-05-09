﻿using Autofac;
using NumberNamesLib.Formatters;
using NumberNamesLib.Infrastructure;
using NUnit.Framework;

namespace NumberNamesTest {
    [TestFixture]
    public class NumberNamesFixture {
        [Test]
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(7, "seven")]
        [TestCase(9, "nine")]
        [TestCase(10, "ten")]
        [TestCase(20, "twenty")]
        [TestCase(21, "twenty one")]
        [TestCase(42, "forty two")]
        [TestCase(77, "seventy seven")]
        [TestCase(99, "ninety nine")]
        [TestCase(100, "one hundred")]
        [TestCase(101, "one hundred and one")]
        [TestCase(121, "one hundred and twenty one")]
        [TestCase(299, "two hundred and ninety nine")]
        [TestCase(500, "five hundred")]
        [TestCase(911, "nine hundred and eleven")]
        [TestCase(999, "nine hundred and ninety nine")]
        [TestCase(1000, "one thousand")]
        [TestCase(1001, "one thousand and one")]
        [TestCase(1002, "one thousand and two")]
        [TestCase(1632, "one thousand and six hundred and thirty two")]
        //[TestCase(, "")]
        public void NumberNames_When_TestDataIntegerIsEntered_Then_TestDataExpectedOutputIsReturned(int input, string expectedOutput)
        {
            // arrange
            var numberNames = IocContainer.Container.Resolve<NumberNameFormatter>();

            // act
            var result = numberNames.Format(input);

            // assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}