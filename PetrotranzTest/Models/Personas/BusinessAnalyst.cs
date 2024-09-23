using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class BusinessAnalyst
    {
        public Book Book { get; set; }

        public BusinessAnalyst(Book book)
        {
            Book = book;
        }

        public List<string> SearchBookTopWords(string path)
        {
            return Book.SearchBookTopWords?.Search(path) ?? throw new NullReferenceException();
        }
    }
}
