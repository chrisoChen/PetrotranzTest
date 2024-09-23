using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class Librarian
    {
        public Book Book { get; set; }

        public Librarian(Book book)
        {
            Book = book;
        }

        public double CalculateBookPages(int totalWords, int wordsPerPage)
        {
            return Book.CalculateBookPages?.Calculate(totalWords, wordsPerPage) ?? throw new NullReferenceException();
        }
    }
}
