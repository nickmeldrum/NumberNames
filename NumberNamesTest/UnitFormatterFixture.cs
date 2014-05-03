using NumberNamesLib.Exceptions;
using NumberNamesLib.Formatters;
using NUnit.Framework;

namespace NumberNamesTest {
    [TestFixture]
    public class UnitFormatterFixture {

        [Test]
        public void UnitFormatter_When_InputIs1_Then_ResultIsOne() {
            // arrange
            var formatter = new UnitFormatter();

            // act
            var value = formatter.Format(1);

            // assert
            Assert.That(value, Is.EqualTo("one"));
        }

        [Test]
        public void UnitFormatter_When_InputIs9_Then_ResultIsNine() {
            // arrange
            var formatter = new UnitFormatter();

            // act
            var value = formatter.Format(9);

            // assert
            Assert.That(value, Is.EqualTo("nine"));
        }

        [Test]
        public void UnitFormatter_When_InputIs1Digit_Then_ResultIsNoException() {
            // arrange
            var formatter = new UnitFormatter();

            // act
            // assert
            Assert.DoesNotThrow(() => formatter.Format(9));
        }

        [Test]
        public void UnitFormatter_When_InputIs2Digits_Then_ResultIsInvalidDigitsException() {
            // arrange
            var formatter = new UnitFormatter();

            // act
            // assert
            Assert.Throws<InvalidDigitsException>(() => formatter.Format(10));
        }
    }

}
