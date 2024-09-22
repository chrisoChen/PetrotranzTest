using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Interfaces
{
    public interface ISearchBookTopWords
    {
        /// <summary>
        /// Finds the most frequently used words in a book.
        /// </summary>
        /// <param name="bookPath">The local path of the book.</param>
        /// <returns>A list of the top most frequently used words in the text. The number depends on the implementation.</returns>
        public List<string> Search(string bookPath);
    }
}
