using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class Student
    {
        private readonly Book _book;

        public Student(Book book)
        {
            _book = book;
        }

        public (int totalWords, int totalCharacters)? CalculateBookStats(string bookPath)
        {
            return _book.CalculateBookStats?.Calculate(bookPath) ?? throw new Exception();
        }

        public int SearchBookTerm(string searchTerm, string path)
        {
            return _book.SearchBookTerm?.Search(path, searchTerm) ?? throw new Exception();
        }
    }
}
