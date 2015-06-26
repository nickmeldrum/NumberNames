namespace NumberNamesLib.Formatters
{
    public class NegativeFormatter : IFormat
    {
        public string Format(int input)
        {
            return input < 0 ? "negative " : "";
        }
    }
}
