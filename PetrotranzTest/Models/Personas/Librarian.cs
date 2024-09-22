using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class Librarian
    {
        private readonly Book _book;

        public Librarian(Book book)
        {
            _book = book;
        }

        public double CalculateBookPages(int totalWords, int wordsPerPage)
        {
            return _book.CalculateBookPages?.Calculate(totalWords, wordsPerPage) ?? throw new Exception();
        }
    }
}
