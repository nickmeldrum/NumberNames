using Autofac;
using NumberNamesLib.Exceptions;
using NumberNamesLib.Formatters;
using NUnit.Framework;
using NumberNamesLib.Infrastructure;

namespace NumberNamesTest {
    [TestFixture]
    public class HundredsFormatterFixture {
        [Test]
        public void HundredsFormatter_When_HundredsPortionIsNotZero_NumberOfHundredsIsReturned() {
            // arrange
            var formatter = IocContainer.Container.Resolve<HundredsFormatter>();

            // act
            var value = formatter.Format(200);

            // assert
            Assert.That(value, Is.EqualTo("two hundred"));
        }

        [Test]
        public void HundredsFormatter_When_InputIsDivisibleExactlyByHundredJustWordHundredIsAppended() {
            // arrange
            var formatter = IocContainer.Container.Resolve<HundredsFormatter>();

            // act
            var value = formatter.Format(200);

            // assert
            Assert.That(value, Is.EqualTo("two hundred"));
        }

        [Test]
        public void HundredsFormatter_When_InputIsNotDivisibleByHundredIsFollowedByWordAnd() {
            // arrange
            var formatter = IocContainer.Container.Resolve<HundredsFormatter>();

            // act
            var value = formatter.Format(201);

            // assert
            Assert.That(value, Is.EqualTo("two hundred and "));
        }

        [Test]
        public void HundredsFormatter_When_InputIs3Digits_Then_ResultIsNoException() {
            // arrange
            var formatter = IocContainer.Container.Resolve<HundredsFormatter>();

            // act
            // assert
            Assert.DoesNotThrow(() => formatter.Format(100));
        }

        [Test]
        public void HundredsFormatter_When_InputIs4Digits_Then_ResultIsInvalidDigitsException() {
            // arrange
            var formatter = IocContainer.Container.Resolve<HundredsFormatter>();

            // act
            // assert
            Assert.Throws<InvalidDigitsException>(() => formatter.Format(1000));
        }
    }

}
