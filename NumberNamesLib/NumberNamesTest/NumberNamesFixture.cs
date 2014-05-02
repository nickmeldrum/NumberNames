using NUnit.Framework;
using NumberNamesLib;

namespace NumberNamesTest {
    [TestFixture]
    public class NumberNamesFixture {
        [Test]
        public void NumberNames_When_0IsEntered_Then_ZeroIsReturned() {
            // arrange
            var numberNames = new NumberNames();

            // act
            var result = numberNames.Format(0);

            // assert
            Assert.That(result, Is.EqualTo("zero"));
        }
    }
}
