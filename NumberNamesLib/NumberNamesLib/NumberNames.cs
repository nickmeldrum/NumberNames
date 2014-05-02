namespace NumberNamesLib
{
    public class NumberNames
    {
        public string Format(int input)
        {
            if (input == 0)
                return FormatZero(input);

            return (FormatTens((input % 100) / 10) + " " + FormatUnits(input % 10)).Trim();
        }

        private string FormatZero(int input) {
            return "zero";
        }

        public string FormatUnits(int input) {
            return (new[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" })[input];
        }

        private string FormatTens(int input)
        {
            return (new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eightty", "ninety" })[input];
        }

    }
}