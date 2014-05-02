using NumberNamesLib.Exceptions;
using NumberNamesLib.Formatters;
using NUnit.Framework;

namespace NumberNamesTest {
    [TestFixture]
    public class ZeroFormatterFixture {

        [Test]
        public void ZeroFormatter_When_InputIs0_Then_ResultIsZero() {
            // arrange
            var formatter = new ZeroFormatter();

            // act
            var value = formatter.Format(0);

            // assert
            Assert.That(value, Is.EqualTo("zero"));
        }

        [Test]
        public void ZeroFormatter_When_InputIsNotZero_Then_ResultIsException() {
            // arrange
            var formatter = new ZeroFormatter();

            // act
            // assert
            Assert.Throws<NumberNotZeroException>(() => formatter.Format(1));
        }
    }

}
