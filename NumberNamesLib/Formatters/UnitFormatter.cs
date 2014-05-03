using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class UnitFormatter : IFormat {
        public string Format(int input) {
            if (input >= 10)
                throw new InvalidDigitsException(1, input);
            return (new[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" })[input];
        }
    }
}
