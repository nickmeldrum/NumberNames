using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class TensFormatter : IFormat {
        private readonly UnitFormatter unitFormatter;

        public TensFormatter(UnitFormatter unitFormatter)
        {
            this.unitFormatter = unitFormatter;
        }

        public string Format(int input) {
            if (input >= 1000)
                throw new InvalidDigitsException(3, input);

            if (input % 100 > 10 && input % 100 < 19)
                    return (new[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" })[input % 100 - 11];

            var format = "";
            if ((input%100) >= 10)
            {
                    format = (new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" })[input % 100 / 10];
                if ((input%100)%10 != 0)
                    format += " ";
            }

            if ((input % 100) % 10 != 0)
                format += this.unitFormatter.Format((input % 100) % 10);

            return format;
        }
    }
}
