using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class ThreeDigitFormatter : IFormat {
        private readonly TensFormatter tensFormatter;
        private readonly HundredsFormatter hundredsFormatter;

        public ThreeDigitFormatter(TensFormatter tensFormatter, HundredsFormatter hundredsFormatter)
        {
            this.tensFormatter = tensFormatter;
            this.hundredsFormatter = hundredsFormatter;
        }

        public string Format(int input)
        {
            if (input >= 1000)
                throw new InvalidDigitsException(3, input);

            return this.hundredsFormatter.Format(input) + this.tensFormatter.Format(input);
        }
    }
}
