using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetrotranzTest.Models.InterfaceTypes
{
    public class SearchBookTerm : ISearchBookTerm
    {
        /// <inheritdoc />
        public int Search(string term, string bookPath)
        {
            string book = File.ReadAllText(bookPath);

            string pattern = term;

            MatchCollection matches = Regex.Matches(book, pattern, RegexOptions.IgnoreCase);
            return matches.Count;
        }
    }
}
