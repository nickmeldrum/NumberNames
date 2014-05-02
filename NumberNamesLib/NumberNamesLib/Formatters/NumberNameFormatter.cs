namespace NumberNamesLib.Formatters
{
    public class NumberNameFormatter
    {
        private readonly ZeroFormatter _zeroFormatter;
        private readonly UnitFormatter _unitFormatter;
        private readonly TensFormatter _tensFormatter;
        private readonly HundredsFormatter _hundredsFormatter;

        public NumberNameFormatter(ZeroFormatter zeroFormatter, UnitFormatter unitFormatter, TensFormatter tensFormatter, HundredsFormatter hundredsFormatter)
        {
            _zeroFormatter = zeroFormatter;
            _unitFormatter = unitFormatter;
            _tensFormatter = tensFormatter;
            _hundredsFormatter = hundredsFormatter;
        }

        public string Format(int input)
        {
            if (input == 0)
                return _zeroFormatter.Format(input);

            return ((_hundredsFormatter.Format(input / 100)) + " and " +
                _tensFormatter.Format((input % 100) / 10) + " " +
                _unitFormatter.Format(input % 10)).Trim();
        }
    }
}