using PetrotranzTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrotranzTest.Models
{
    public abstract class Book
    {
        public ICalculateBookPages? CalculateBookPages { get; set; }
        public ICalculateBookStats? CalculateBookStats { get; set; }

        public ISearchBookTerm? SearchBookTerm { get; set; }
        public ISearchBookTopWords? SearchBookTopWords { get; set; }

        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public Book(ICalculateBookPages? calculateBookPages, ICalculateBookStats? calculateBookStats, ISearchBookTerm? searchBookTerm, ISearchBookTopWords? searchBookTopWords)
        {
            CalculateBookPages = calculateBookPages;
            CalculateBookStats = calculateBookStats;
            SearchBookTerm = searchBookTerm;
            SearchBookTopWords = searchBookTopWords;
        }

    }
}
