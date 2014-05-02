using NUnit.Framework;
using NumberNamesLib;

namespace NumberNamesTest {
    [TestFixture]
    public class NumberNamesFixture {
        [Test]
        public void NumberNames_When_0IsEntered_Then_ZeroIsReturned()
        {
            TestNumber(0, "zero");
        }

        private void TestNumber(int input, string expectedOutput)
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
