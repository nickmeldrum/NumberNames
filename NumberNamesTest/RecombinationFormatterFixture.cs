using Autofac;
using NUnit.Framework;
using NumberNamesLib.Formatters;
using NumberNamesLib.Infrastructure;

namespace NumberNamesTest {
    [TestFixture]
    public class RecombinationFormatterFixture {
        [Test]
        public void RecombinationFormatter_When_FormattingANumberWith2ThreeDigitGroups_Then_ResultHas1st3DigitGroupFollowedByALargeNumberName() {
            // arrange
            var recombinationFormatter = IocContainer.Container.Resolve<RecombinationFormatter>();

            // act
            var result = recombinationFormatter.Format(1001);

            // assert
            Assert.That(result, Is.EqualTo("one thousand and one"));
        }
    }
}
