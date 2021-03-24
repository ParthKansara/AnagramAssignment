using AnagramsAssignment.Helper;
using AnagramsAssignment.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace AnagramsAssignment.Services
{
    public class AnagramService : IAnagramService
    {
        /// <summary>
        /// Retuns List of Anagrams from the wordlist (file)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> GetAnagrams(string input)
        {
            // Read Text file to Get Word List
            List<string> wordList = FileHelper.FetchWordListFromFileByFileName("Wordlist.txt");
            
            // Initialize the Result List
            List<string> resultList = new List<string>();

            // Sort the Input Array
            char[] inputCharctersArray = input.ToLower().ToCharArray();
            Array.Sort(inputCharctersArray);
            string sortedUserInput = new string(inputCharctersArray);

            char[] dictionaryWordsCharacterArray;

            wordList.ForEach(w =>
            {
                dictionaryWordsCharacterArray = w.ToCharArray();
                Array.Sort(dictionaryWordsCharacterArray);
                
                string currentValue = new string(dictionaryWordsCharacterArray);

                // If word is Anagram of Sorted User Input then Add to the List
                if (sortedUserInput.Equals(currentValue)) {
                    resultList.Add(w);
                }
            });

            return resultList;
        }
    }
}
