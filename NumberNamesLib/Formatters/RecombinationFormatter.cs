using System.Globalization;

namespace NumberNamesLib.Formatters {
    using System;

    public class RecombinationFormatter : IFormat {
        private readonly ThreeDigitFormatter threeDigitFormatter;

        private readonly NegativeFormatter negativeFormatter;

        public RecombinationFormatter(ThreeDigitFormatter threeDigitFormatter, NegativeFormatter negativeFormatter)
        {
            this.threeDigitFormatter = threeDigitFormatter;
            this.negativeFormatter = negativeFormatter;
        }

        public string Format(int input)
        {
            var output = negativeFormatter.Format(input);

            var threeDigitGroups = CreateThreeDigitGroupSplit(Math.Abs(input));
            for (var i = 0; i < threeDigitGroups.Length; i++)
            {
                if (threeDigitGroups[i] != 0)
                {
                    // if at final comma, and last group has no hundreds + more than 1 group 
                    // then combiner = and otherwise it's a ,
                    var combiner = ", ";
                    if (i == 0) combiner = "";
                    else if (i == threeDigitGroups.Length - 1 && threeDigitGroups[i] / 100 == 0) combiner = " and ";

                    output += combiner + CreateThreeDigitStringRepresentation(threeDigitGroups, i);
                }
            }

            return output;
        }

        public string CreateThreeDigitStringRepresentation(int[] threeDigitGroups, int position)
        {
            var bigNumberNames = new[] { "", " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion" };

            return this.threeDigitFormatter.Format(threeDigitGroups[position]) + bigNumberNames[threeDigitGroups.Length - position - 1];
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
