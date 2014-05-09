using Autofac;
using NUnit.Framework;
using NumberNamesLib.Formatters;
using NumberNamesLib.Infrastructure;

namespace NumberNamesTest {
    [TestFixture]
    public class RecombinationFormatterFixture {
        [Test]
        public void RecombinationFormatter_When_FormattingExactlyOneThousand_Then_ResultDoesNotHaveExtraSpacesOrAnds() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();

            // act
            var result = recombinationFormatter.Format(1000);

            // assert
            Assert.That(result, Is.EqualTo("one thousand"));
        }

        [Test]
        public void RecombinationFormatter_When_FormattingANumberWith2ThreeDigitGroups_Then_ResultHas23DigitGroupRepresentationsSeparatedByAnd() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();

            // act
            var result = recombinationFormatter.Format(1002);

            // assert
            Assert.That(result, Is.EqualTo("one thousand and two"));
        }

        [Test]
        public void RecombinationFormatter_When_CreatingAThreeDigitRepresentationOfPosition1Of1002_Then_ResultIsOneThousand() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();
            var array = recombinationFormatter.CreateThreeDigitGroupSplit(1002);

            // act
            var result = recombinationFormatter.CreateThreeDigitStringRepresentation(array, 0);

            // assert
            Assert.That(result, Is.EqualTo("one thousand"));
        }

        [Test]
        public void RecombinationFormatter_When_CreatingAThreeDigitRepresentationOfPosition2Of1002_Then_ResultIsTwo() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();
            var array = recombinationFormatter.CreateThreeDigitGroupSplit(1002);

            // act
            var result = recombinationFormatter.CreateThreeDigitStringRepresentation(array, 1);

            // assert
            Assert.That(result, Is.EqualTo("two"));
        }

        [Test]
        public void RecombinationFormatter_When_Splitting1002Into3Digits_Then_ResultIs2IntsOf1And2() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();

            // act
            var result = recombinationFormatter.CreateThreeDigitGroupSplit(1002);

            // assert
            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[1], Is.EqualTo(2));
        }
    }
}
