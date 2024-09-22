using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class SearchBookTopWords : ISearchBookTopWords
    {
        private readonly int _maxWords;

        public SearchBookTopWords(int maxWords = 10)
        {
            _maxWords = maxWords;
        }

        public List<string> Search(string bookPath)
        {
            return new List<string>();
        }
    }
}
