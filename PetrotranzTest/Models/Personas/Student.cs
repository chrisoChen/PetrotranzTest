using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class Student
    {
        public Book Book { get; set; }

        public Student(Book book)
        {
            Book = book;
        }

        public (int totalWords, int totalCharacters) CalculateBookStats(string bookPath)
        {
            return Book.CalculateBookStats?.Calculate(bookPath) ?? throw new NullReferenceException();
        }

        public int SearchBookTerm(string searchTerm, string path)
        {
            return Book.SearchBookTerm?.Search(searchTerm, path) ?? throw new NullReferenceException();
        }
    }
}
