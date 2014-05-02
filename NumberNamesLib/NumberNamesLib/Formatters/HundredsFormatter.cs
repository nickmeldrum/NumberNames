namespace NumberNamesLib.Formatters {
    public class HundredsFormatter : IFormat {
        private readonly UnitFormatter _unitFormatter;

        public HundredsFormatter(UnitFormatter unitFormatter)
        {
            _unitFormatter = unitFormatter;
        }

        public string Format(int input) {
            // assuming our input here is 3 digits
            // TODO: add in exceptions with tests for this

            var format = "";
            if (input >= 100) {
                format = (_unitFormatter.Format(input / 100));
                if (input % 100 == 0)
                    format += " hundred";
                else
                    format += " hundred and ";
            }

            return format;
        }
    }
}
