namespace NumberNamesLib.Formatters
{
    public class NumberNameFormatter
    {
        private readonly ZeroFormatter _zeroFormatter;
        private readonly ThreeDigitFormatter _threeDigitFormatter;

        public NumberNameFormatter(ZeroFormatter zeroFormatter, ThreeDigitFormatter threeDigitFormatter)
        {
            _zeroFormatter = zeroFormatter;
            _threeDigitFormatter = threeDigitFormatter;
        }

        public string Format(int input)
        {
            if (input == 0)
                return _zeroFormatter.Format(input);

            return _threeDigitFormatter.Format(input);
        }
    }
}