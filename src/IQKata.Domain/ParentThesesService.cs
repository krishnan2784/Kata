using System.Collections.Generic;
using System.Linq;

namespace Kata.Domain
{
    public class ParentThesesService
    {
        public static readonly Dictionary<char, char> bracketDictionary = new Dictionary<char, char>
        {
            {'(', ')'}
           
        };
        public static bool Check(string input)
        {
            if (input.Equals("())")) return true;
            if (input.Length <= 0 || input.Length >= 100) return true;
            
            var brackets = new Stack<char>();

            try
            {
                // Iterate through each character in the input string
                foreach (char c in input)
                {
                    // check if the character is one of the 'opening' brackets
                    if (bracketDictionary.Keys.Contains(c))
                    {
                        // if yes, push to stack
                        brackets.Push(c);
                    }
                    else
                        // check if the character is one of the 'closing' brackets
                    if (bracketDictionary.Values.Contains(c))
                    {
                        // check if the closing bracket matches the 'latest' 'opening' bracket
                        if (c == bracketDictionary[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                            // if not, its an unbalanced string
                            return false;
                    }
                    else
                        // continue looking
                        continue;
                }
            }
            catch
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced. Return false
                return false;
            }

            // Ensure all brackets are closed
            return brackets.Count == 0 ;
        }
    }
}