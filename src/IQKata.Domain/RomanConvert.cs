using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Domain
{
    public static class RomanConvert
    {
        public static string Solution(int InputNumber)
        {
            var returnValue = "";

            // Declare dictionary to hold Arabic numbers and Roman equivalents.
            // Sorted dictionary used to ensure order of entries. In this case,
            // the dictionary will be sorted starting with the last entry where the key is 1.
            var dyRoman = new SortedDictionary<int, char>
            {
                { 1000, 'M' },
                { 500, 'D' },
                { 100, 'C' },
                { 50, 'L' },
                { 10, 'X' },
                { 5, 'V' },
                { 1, 'I' }
            };

            try
            {
                // The class currently does not process numbers over 3999.
                if (InputNumber > 3999 || InputNumber < 1)
                {
                    throw new ArgumentOutOfRangeException
                        ("Input values must be between 1 and 3999.", new Exception());
                }

                // Start at the end of the dictionary. Sorted dictionary orders by the key so 1000 is at the end.
                // Get Arabic number, Roman character and the subtractive level under it.
                var dictionaryElement = dyRoman.Count - 1;
                var arabicNumber = dyRoman.ElementAt(dictionaryElement).Key;     // Holds arabic number and "9" place under it i.e. 1000 and 900, 10 and 9
                var romanChar = dyRoman.ElementAt(dictionaryElement).Value;
                var arabicSubLevel = arabicNumber - ((arabicNumber.ToString()[0] == '1') ? (arabicNumber / 10) : (arabicNumber / 5));     // Holds arabic number and "9" place under it i.e. 1000 and 900, 10 and 9

                // InputNumber will be continually reduced as the Roman numeral is built.
                while (InputNumber > 0 && InputNumber < 4000)
                {
                    if (InputNumber >= arabicNumber) // If the number remains above the current test.
                    {
                        // If the current Roman numeral ends with three of the current Roman character,
                        // and the current Arabic number starts with 1, remove the three characters and
                        // add the subtractive notation (i.e. III to IV and XXXVIII to XXXIX)
                        if (returnValue.EndsWith(new string(romanChar, 3)) && arabicNumber.ToString()[0] == '1')
                        {
                            returnValue = returnValue.Substring(0, returnValue.Length - 3);
                            returnValue += romanChar;
                            returnValue += dyRoman.ElementAt(dictionaryElement + 1).Value;
                        }
                        else // Otherwise, just add another character.
                        {
                            returnValue += dyRoman.ElementAt(dictionaryElement).Value;
                        }

                        // Subtract the amount that has been added to the Roman numeral.
                        InputNumber -= arabicNumber;
                    }
                    else if (InputNumber >= arabicSubLevel)
                    {
                        // If the number is less than the current level but greater than the sublevel
                        // (i.e. less than 1000 but 900 or greater), add the appropriate letters.

                        if (arabicNumber.ToString()[0] == '1')
                        {
                            returnValue += dyRoman.ElementAt(dictionaryElement - 2).Value;
                        }
                        else
                        {
                            returnValue += dyRoman.ElementAt(dictionaryElement - 1).Value;
                        }

                        returnValue += dyRoman.ElementAt(dictionaryElement).Value;

                        // Subtract the amount that has been added to the Roman numeral.
                        InputNumber -= arabicSubLevel;
                    }
                    else
                    {
                        // Otherwise, move forward in the dictionary and get the new values.
                        dictionaryElement--;
                        arabicNumber = dyRoman.ElementAt(dictionaryElement).Key;
                        romanChar = dyRoman.ElementAt(dictionaryElement).Value;
                        arabicSubLevel = arabicNumber - ((arabicNumber.ToString()[0] == '1') ? (arabicNumber / 10) : (arabicNumber / 5));
                    }
                }

            }
            catch (Exception ex)
            {
                returnValue = "";
                throw ex;
            }

            return returnValue;
        }
    }

}