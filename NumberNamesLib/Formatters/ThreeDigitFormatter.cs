using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class ThreeDigitFormatter : IFormat {
        private readonly TensFormatter _tensFormatter;
        private readonly HundredsFormatter _hundredsFormatter;

        public ThreeDigitFormatter(TensFormatter tensFormatter, HundredsFormatter hundredsFormatter)
        {
            _tensFormatter = tensFormatter;
            _hundredsFormatter = hundredsFormatter;
        }

        public string Format(int input)
        {
            if (input >= 1000)
                throw new InvalidDigitsException(3, input);

            return _hundredsFormatter.Format(input) + _tensFormatter.Format(input);
        }
    }
}
