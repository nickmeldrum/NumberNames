namespace NumberNamesLib.Formatters {
    public class UnitFormatter : IFormat {
        public string Format(int input) {
            return (new[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" })[input];
        }
    }
}
