using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class SearchBookTerm : ISearchBookTerm
    {
        public int Search(string term, string bookPath)
        {
            return 0;
        }
    }
}
