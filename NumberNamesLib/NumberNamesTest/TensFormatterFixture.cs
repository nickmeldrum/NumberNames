using Autofac;
using NumberNamesLib.Exceptions;
using NumberNamesLib.Formatters;
using NUnit.Framework;
using NumberNamesLib.Infrastructure;

namespace NumberNamesTest {
    [TestFixture]
    public class TensFormatterFixture {
        [Test]
        public void TensFormatter_When_InputHasTensSection2OrHigher_Then_ResultIsCorrectTyWord() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            var value = formatter.Format(20);

            // assert
            Assert.That(value, Is.EqualTo("twenty"));
        }

        [Test]
        public void TensFormatter_When_InputHasTensSection2OrHigherAndUnits_Then_ResultIsCorrectTyWordWithNumberAfterIt() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            var value = formatter.Format(21);

            // assert
            Assert.That(value, Is.EqualTo("twenty one"));
        }

        [Test]
        public void TensFormatter_When_TensAndUnitsAreBothZero_NoTextIsReturned() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            var value = formatter.Format(100);

            // assert
            Assert.That(value, Is.EqualTo(""));
        }

        [Test]
        public void TensFormatter_When_DigitsIsInTeens_Then_TheSpecialCaseTeensWordIsReturned() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            var value = formatter.Format(16);

            // assert
            Assert.That(value, Is.EqualTo("sixteen"));
        }

        [Test]
        public void TensFormatter_When_InputIs3Digits_Then_ResultIsNoException() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            // assert
            Assert.DoesNotThrow(() => formatter.Format(100));
        }

        [Test]
        public void TensFormatter_When_InputIs4Digits_Then_ResultIsInvalidDigitsException() {
            // arrange
            var formatter = IocContainer.Container.Resolve<TensFormatter>();

            // act
            // assert
            Assert.Throws<InvalidDigitsException>(() => formatter.Format(1000));
        }
    }

}
