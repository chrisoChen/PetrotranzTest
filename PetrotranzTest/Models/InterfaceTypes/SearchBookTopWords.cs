using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class SearchBookTopWords : ISearchBookTopWords
    {
        private readonly int _maxWords;
        public int MaxWords { get { return _maxWords; } }

        public SearchBookTopWords(int maxWords = 10)
        {
            _maxWords = maxWords;
        }

        /// <inheritdoc />
        public List<string> Search(string bookPath)
        {
            var dictionary = new Dictionary<string, int>();

            string book = File.ReadAllText(bookPath);
            book = book.Replace("\r", " ").Replace("\n", " ");

            // Remove punctuation from the text
            book = Regex.Replace(book, @"\p{P}", "");

            string[] words = book.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (dictionary.ContainsKey(lowerWord))
                {
                    dictionary[lowerWord]++;
                }
                else
                {
                    dictionary.Add(lowerWord, 1);
                }
            }

            return dictionary.OrderByDescending(x => x.Value).Take(_maxWords).Select(x => x.Key).ToList();
        }
    }
}
