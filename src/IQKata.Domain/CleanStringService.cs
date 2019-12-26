using System.Collections.Generic;
using System.Linq;

namespace Kata.Domain
{
    public class CleanStringService
    {
        public static string CleanString(string s)
        {
            var cleanedStringList= new List<char>();
            var characterList = s.ToCharArray().ToList();
            foreach (var character in characterList)
            {
                if (character.Equals('#'))
                {
                    if(cleanedStringList.Count>0)
                        cleanedStringList.RemoveAt(cleanedStringList.Count - 1);
                }
                else
                    cleanedStringList.Add(character);
            }

            return string.Concat(cleanedStringList);
        }
    }
}