# "Number Names"
An example of a completion of a pretty typical interview test/ kata for converting integers into the british string equivalent.

Written in C#.

# Code Test
 
Take a number and give the equivalent number in British English words e.g.

* 1 = one
* 21 = twenty one
* 105 = one hundred and five
* 56945781 = fifty six million, nine hundred and forty five thousand, seven hundred and eighty one

etc. up to 999,999,999.

As a pointer on what we would be looking for in the app:

* Test Driven Development
* Application of good OO design principles to solve the problem e.g.
* clear separation of concerns
* well defined objects / interfaces
* application of patterns to solve the problem if possible
* well tested code
* well refactored code
* A procedural approach to this code is strongly discouraged

# Large Number Names

The English names of smaller numbers are generally accepted. However, once a number to be converted reaches a value of one thousand million or greater, the names of numbers vary according to usage. The algorithm described in this article uses the modern short scale numbering. In this scale, one thousand million is equivalent to one billion. This is different to the less-used traditional British long scale numbering where a billion is one million million.

The following table lists the short scale number names included in the algorithm and their numeric values. The range of numbers has been selected to provide for the full range of values that may be held in a 32-bit integer. If you wish to extend the functionality of the algorithm to larger numbers, a Wikipedia article exists that lists the names of large numbers.

## Value:	Name
 * 1:	one
 * 10:	ten
 * 100:	hundred
 * 1,000:	thousand
 * 1,000,000:	million
 * 1,000,000,000:	billion

## Number Rules

The set of rules for converting an integer number to text initially appear to be reasonably complex. however, once analysed, they can be separated into a small number of distinct rule groups that are simpler to implement individually. To provide a single algorithm for all the integer values there are six such rule groups:

1. Zero Rule: If the value is zero then the number in words is ‘zero’ and no other rules apply.

2. Three Digit Rule: The integer value is split into groups of three digits starting from the right-hand side. Each set of three digits is then processed individually as a number of hundreds, tens and units. Once converted to text, the three-digit groups are recombined with the addition of the relevant scale number (thousand, million, billion.)

3. Hundreds Rule: If the hundreds portion of a three-digit group is not zero, the number of hundreds is added to the word. If the three-digit group is exactly divisible by one hundred, the text ‘hundred’ is appended. If not, the text ‘hundred and’ is appended e.g. ‘two hundred’ or ‘one hundred and twelve’

4. Tens Rules: If the tens section of a three-digit group is two or higher the appropriate ‘-ty’ word (twenty, thirty, etc) is added to the text and followed by the name of the third digit (unless the third digit is zero, which is ignored). If the tens and the units are both zero, no text is added. For any other value, the name of the one or two-digit number is added as a special case.

5. Recombination Rules: When recombining the translated three-digit groups, each group except the last is followed by a large number name and a comma, unless the group is blank and therefore not included at all. One exception is when the final group does not include any hundreds and there is more than one non-blank group. In this case the final comma is replaced with ‘and’ e.g. ‘one billion, one million and twelve’.

6. Negative Rule: Negative number are always preceded by the text ‘negative’.
