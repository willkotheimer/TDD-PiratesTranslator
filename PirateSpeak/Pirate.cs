using System;
using System.Collections.Generic;
using System.Linq;

namespace PirateSpeak
{
    public class Pirate
    {
        public IEnumerable<string> GetPossibleWords(string word, List<string> possibles)
        {
            var sortedWord = sortLetters(word);
            IEnumerable<string> myArrrghA = possibles.Where(c => sortedWord == sortLetters(c));
            return myArrrghA.ToList();
        }

        public string sortLetters(string word)
        {
            return String.Concat(word.OrderBy(c => c));
        }
    }
}
