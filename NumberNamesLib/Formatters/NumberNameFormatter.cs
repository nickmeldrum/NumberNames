namespace NumberNamesLib.Formatters
{
    public class NumberNameFormatter
    {
        private readonly ZeroFormatter _zeroFormatter;
        private readonly RecombinationFormatter _recombinationFormatter;

        public NumberNameFormatter(ZeroFormatter zeroFormatter, RecombinationFormatter recombinationFormatter)
        {
            _zeroFormatter = zeroFormatter;
            _recombinationFormatter = recombinationFormatter;
        }

        public string Format(int input)
        {
            return input == 0 ? _zeroFormatter.Format(input) : _recombinationFormatter.Format(input);
        }
    }
}