using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Interfaces
{
    public interface ICalculateBookStats
    {
        /// <summary>
        /// Calculates the total number of words and characters in a book.
        /// </summary>
        /// <param name="bookPath">The local path of the book.</param>
        /// <returns>The total words and characters in the book.</returns>
        public (int totalWords, int totalCharacters) Calculate(string bookPath);
    }
}
