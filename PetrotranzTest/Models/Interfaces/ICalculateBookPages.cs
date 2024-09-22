using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Interfaces
{
    public interface ICalculateBookPages
    {
        /// <summary>
        /// Calculate the number of pages in a book.
        /// </summary>
        /// <param name="totalWords">The total words in a book</param>
        /// <param name="wordsPerPage">How many words a page can contain in a book</param>
        /// <returns>The total number of pages in a book</returns>
        double Calculate(int totalWords, int wordsPerPage);
    }
}
