using System.Globalization;

namespace NumberNamesLib.Formatters {
    public class RecombinationFormatter : IFormat {
        private readonly ThreeDigitFormatter _threeDigitFormatter;

        public RecombinationFormatter(ThreeDigitFormatter threeDigitFormatter)
        {
            _threeDigitFormatter = threeDigitFormatter;
        }

        public string Format(int input)
        {
            var output = "";

            var threeDigitGroups = CreateThreeDigitGroupSplit(input);
            for (var i = 0; i < threeDigitGroups.Length; i++)
            {
                var threeDigitStringRepresentation = CreateThreeDigitStringRepresentation(threeDigitGroups, i);
                output += threeDigitStringRepresentation + (i == threeDigitGroups.Length - 1 ? " and " : "");
            }
            return output;
        }

        public string CreateThreeDigitStringRepresentation(int[] threeDigitGroups, int position)
        {
            var bigNumberNames = new[] { "", " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion" };

            return _threeDigitFormatter.Format(threeDigitGroups[position]) + bigNumberNames[threeDigitGroups.Length - position - 1];
        }

        public int[] CreateThreeDigitGroupSplit(int input)
        {
            var inputAsString = input.ToString(CultureInfo.InvariantCulture);

            var numberOf3DigitGroups = inputAsString.Length / 3;
            if (inputAsString.Length % 3 > 0) numberOf3DigitGroups++;

            var result = new int[numberOf3DigitGroups];

            for (var i = numberOf3DigitGroups; i > 0; i--)
            {
                result[i - 1] = int.Parse(inputAsString.Substring((inputAsString.Length - 3 > 0 ? inputAsString.Length - 3 : 0), (inputAsString.Length < 3) ? inputAsString.Length : 3));
                if (inputAsString.Length > 3)
                    inputAsString = inputAsString.Substring(0, inputAsString.Length - 3);
            }

            return result;
        }
    }
}
