namespace NumberNamesLib.Formatters
{
    public class NumberNameFormatter
    {
        private readonly ZeroFormatter zeroFormatter;
        private readonly RecombinationFormatter recombinationFormatter;

        public NumberNameFormatter(ZeroFormatter zeroFormatter, RecombinationFormatter recombinationFormatter)
        {
            this.zeroFormatter = zeroFormatter;
            this.recombinationFormatter = recombinationFormatter;
        }

        public string Format(int input)
        {
            return input == 0 ? this.zeroFormatter.Format(input) : this.recombinationFormatter.Format(input);
        }
    }
}