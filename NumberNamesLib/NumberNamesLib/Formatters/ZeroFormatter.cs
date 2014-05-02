using NumberNamesLib.Exceptions;

namespace NumberNamesLib.Formatters {
    public class ZeroFormatter : IFormat {
        public string Format(int input)
        {
            if (input != 0)
                throw new NumberNotZeroException();
            return "zero";
        }
    }
}
