namespace NumberNamesLib.Formatters {
    public class HundredsFormatter : IFormat {
        private readonly UnitFormatter _unitFormatter;

        public HundredsFormatter(UnitFormatter unitFormatter)
        {
            _unitFormatter = unitFormatter;
        }

        public string Format(int input) {
            if (input == 0)
                return "";

            return _unitFormatter.Format(input) + " hundred";
        }
    }
}
