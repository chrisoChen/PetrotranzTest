using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class CalculateBookStats : ICalculateBookStats
    {
        /// <inheritdoc />
        public (int totalWords, int totalCharacters) Calculate(string bookPath)
        {
            string book = File.ReadAllText(bookPath);
            
            // Remove whitespace and extra characters
            book = book.Replace("\r", " ").Replace("\n", " ");
            string[] words = book.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            string joinedWords = String.Join("", words);

            int totalWords = words.Length;
            int totalCharacters = joinedWords.Length;

            return (totalWords, totalCharacters);
        }
    }

}
