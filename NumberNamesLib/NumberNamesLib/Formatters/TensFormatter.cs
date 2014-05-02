using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class TensFormatter : IFormat {
        private readonly UnitFormatter _unitFormatter;

        public TensFormatter(UnitFormatter unitFormatter)
        {
            _unitFormatter = unitFormatter;
        }

        public string Format(int input) {
            if (input >= 1000)
                throw new InvalidDigitsException(3, input);

            var format = "";
            if ((input%100) >= 10)
            {
                format = (new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eightty", "ninety" })[input % 100 / 10];
                if ((input%100)%10 != 0)
                    format += " ";
            }

            if ((input % 100) % 10 != 0)
                format += _unitFormatter.Format((input % 100) % 10);

            return format;
        }
    }
}
