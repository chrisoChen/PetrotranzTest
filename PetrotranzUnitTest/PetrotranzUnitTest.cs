using PetrotranzTest.Models;
using PetrotranzTest.Models.InterfaceTypes;
using PetrotranzTest.Models.Personas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace PetrotranzUnitTest
{
    [TestClass]
    public class PetrotranzUnitTest
    {
        private TextFileBook _studentTextFileBook;
        private TextFileBook _librarianTextFileBook;
        private TextFileBook _businessAnalystTextFileBook;

        public PetrotranzUnitTest()
        {
            _librarianTextFileBook = new TextFileBook(new CalculateBookPages(), null, null, null);
            _studentTextFileBook = new TextFileBook(null, new CalculateBookStats(), new SearchBookTerm(), null);
            _businessAnalystTextFileBook = new TextFileBook(null, null, null, new SearchBookTopWords());
        }

        [TestMethod]
        public void TestLibrarianSearchBookTopWords()
        {
            var librarian = new Librarian(_librarianTextFileBook);
            int totalWords = 50000;
            int wordsPerPage = 250;
            double expectedPages = 200;

            double? pages = librarian.CalculateBookPages(totalWords, wordsPerPage);

            Assert.AreEqual(expectedPages, pages);
        }

    }
}