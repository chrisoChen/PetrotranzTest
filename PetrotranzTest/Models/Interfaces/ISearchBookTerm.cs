using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Interfaces
{
    public interface ISearchBookTerm
    {
        /// <summary>
        /// Search for a specific word in a book.
        /// </summary>
        /// <param name="term">The word to search for.</param>
        /// <param name="bookPath">The local path of the book.</param>
        /// <returns>The occurences of the word in the text.</returns>
        public int Search(string term, string bookPath);
    }
}
