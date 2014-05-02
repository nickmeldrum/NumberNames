namespace NumberNamesLib
{
    public class NumberNames
    {
        public string Format(int input)
        {
            return (new [] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"})[input];
        }
    }
}