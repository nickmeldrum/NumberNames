namespace NumberNamesLib
{
    public class NumberNames
    {
        public string Format(int input)
        {
            if (input == 0)
                return "zero";

            // format 1st "3 digit" set
            return (new [] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"})[input];
        }
    }
}