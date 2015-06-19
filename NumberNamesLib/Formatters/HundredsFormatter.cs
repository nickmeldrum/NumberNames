using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class HundredsFormatter : IFormat {
        private readonly UnitFormatter unitFormatter;

        public HundredsFormatter(UnitFormatter unitFormatter)
        {
            this.unitFormatter = unitFormatter;
        }

        public string Format(int input) {
            if (input >= 1000)
                throw new InvalidDigitsException(3, input);

            var format = "";
            if (input >= 100) {
                format = (this.unitFormatter.Format(input / 100));
                if (input % 100 == 0)
                    format += " hundred";
                else
                    format += " hundred and ";
            }

            return format;
        }
    }
}
