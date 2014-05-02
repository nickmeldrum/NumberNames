namespace NumberNamesLib.Formatters {
    public class ThreeDigitFormatter : IFormat {
        private readonly UnitFormatter _unitFormatter;
        private readonly TensFormatter _tensFormatter;
        private readonly HundredsFormatter _hundredsFormatter;

        public ThreeDigitFormatter(UnitFormatter unitFormatter, TensFormatter tensFormatter, HundredsFormatter hundredsFormatter)
        {
            _unitFormatter = unitFormatter;
            _tensFormatter = tensFormatter;
            _hundredsFormatter = hundredsFormatter;
        }

        public string Format(int input)
        {
            // assuming our input here is 3 digits
            // TODO: add in exceptions with tests for this

            return _hundredsFormatter.Format(input) +
                _tensFormatter.Format(input)
                ;
        }
    }
}
