using Autofac;
using NumberNamesLib.Formatters;
using NumberNamesLib.Infrastructure;
using NUnit.Framework;

namespace NumberNamesTest {
    [TestFixture]
    public class NumberNamesFixture {
        [Test]
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(-1, "negative one")]
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
        [TestCase(-101, "negative one hundred and one")]
        [TestCase(121, "one hundred and twenty one")]
        [TestCase(299, "two hundred and ninety nine")]
        [TestCase(500, "five hundred")]
        [TestCase(911, "nine hundred and eleven")]
        [TestCase(999, "nine hundred and ninety nine")]
        [TestCase(1000, "one thousand")]
        [TestCase(1001, "one thousand and one")]
        [TestCase(1002, "one thousand and two")]
        [TestCase(-1002, "negative one thousand and two")]
        [TestCase(1632, "one thousand, six hundred and thirty two")]
        [TestCase(-1632, "negative one thousand, six hundred and thirty two")]
        [TestCase(1000001, "one million and one")]
        [TestCase(-1000001, "negative one million and one")]
        [TestCase(1000000, "one million")]
        [TestCase(-1000000, "negative one million")]
        [TestCase(999999, "nine hundred and ninety nine thousand, nine hundred and ninety nine")]
        [TestCase(-999999, "negative nine hundred and ninety nine thousand, nine hundred and ninety nine")]
        [TestCase(56945781, "fifty six million, nine hundred and forty five thousand, seven hundred and eighty one")]
        [TestCase(-56945781, "negative fifty six million, nine hundred and forty five thousand, seven hundred and eighty one")]
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
