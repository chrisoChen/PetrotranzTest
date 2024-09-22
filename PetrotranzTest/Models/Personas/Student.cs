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

        public void CalculateBookStats(string bookPath)
        {
            _book?.CalculateBookStats?.Calculate(bookPath);
        }

        public void SearchBookTerm(string searchTerm, string path)
        {
            _book?.SearchBookTerm?.Search(path, searchTerm);
        }
    }
}
