using NUnit.Framework;
using NumberNamesLib;

namespace NumberNamesTest {
    [TestFixture]
    public class NumberNamesFixture {
        [Test]
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(7, "seven")]
        [TestCase(9, "nine")]
        public void NumberNames_When_TestDataIntegerIsEntered_Then_TestDataExpectedOutputIsReturned(int input, string expectedOutput)
        {
            // arrange
            var numberNames = new NumberNames();

            // act
            var result = numberNames.Format(input);

            // assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
