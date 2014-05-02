namespace NumberNamesLib.Formatters {
    public class TensFormatter : IFormat {
        public string Format(int input) {
            return (new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eightty", "ninety" })[input];
        }
    }
}
