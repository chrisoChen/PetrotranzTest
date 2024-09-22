using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models
{
    public class TextFileBook : Book
    {
        public TextFileBook(ICalculateBookPages? calculateBookPages, ICalculateBookStats? calculateBookStats, ISearchBookTerm? searchBookTerm, ISearchBookTopWords? searchBookTopWords) 
            : base(calculateBookPages, calculateBookStats, searchBookTerm, searchBookTopWords) { }
    }
}
