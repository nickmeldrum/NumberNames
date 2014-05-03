using System;

namespace NumberNamesLib.Exceptions {
    public class InvalidDigitsException : Exception {
        public InvalidDigitsException(int digitsExpected, int input) : base(
            string.Format("Invalid number of digits expected ({0}), number was {1}", digitsExpected, input))
        {
            
        }
    }
}
