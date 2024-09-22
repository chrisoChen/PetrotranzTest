using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.Personas
{
    public class BusinessAnalyst
    {
        private readonly Book _book;

        public BusinessAnalyst(Book book)
        {
            _book = book;
        }

        public void SearchBookTopWords(string path)
        {
            _book?.SearchBookTopWords?.Search(path);
        }
    }
}
