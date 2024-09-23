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
        private readonly TextFileBook _studentTextFileBook;
        private readonly TextFileBook _librarianTextFileBook;
        private readonly TextFileBook _businessAnalystTextFileBook;

        public PetrotranzUnitTest()
        {
            _librarianTextFileBook = new TextFileBook(new CalculateBookPages(), null, null, null);
            _studentTextFileBook = new TextFileBook(null, new CalculateBookStats(), new SearchBookTerm(), null);
            _businessAnalystTextFileBook = new TextFileBook(null, null, null, new SearchBookTopWords());
        }

        [TestMethod]
        public void TestLibrarianCalculateBookPages()
        {
            var librarian = new Librarian(_librarianTextFileBook);
            int totalWords = 50000;
            int wordsPerPage = 250;
            double expectedPages = 200;

            double? pages = librarian.CalculateBookPages(totalWords, wordsPerPage);

            librarian.Book.Display($"Total Pages: {pages}");
            Assert.AreEqual(expectedPages, pages);
        }

        [TestMethod]
        public void TestLibrarianCalculateBookPagesZeroWordsPerPage()
        {
            var librarian = new Librarian(_librarianTextFileBook);
            int totalWords = 50000;
            int wordsPerPage = 0;

            try
            {
                double? pages = librarian.CalculateBookPages(totalWords, wordsPerPage);
            }
            catch (DivideByZeroException ex)
            {
                librarian.Book.Display(ex.Message);
                Assert.IsTrue(ex.Message.Equals("Words per page cannot be zero."));
            }
        }

        [TestMethod]
        public void TestStudentCalculateBookStatsTwoCities()
        {
            var student = new Student(_studentTextFileBook);
            string bookPath = Path.Combine(
                Directory.GetCurrentDirectory(), 
                "Books", 
                "A Tale of Two Cities - Charles Dickens.txt");

            (int totalWords, int totalCharacters) = student.CalculateBookStats(bookPath);

            int expectedTotalWords = 138883;
            int expectedTotalCharacters = 633441;

            student.Book.Display($"Total Words: {totalWords}, Total Characters: {totalCharacters}");
            Assert.IsTrue(totalWords.Equals(expectedTotalWords) && totalCharacters.Equals(expectedTotalCharacters));
        }

        [TestMethod]
        public void TestStudentCalculateBookStatsAlice()
        {
            var student = new Student(_studentTextFileBook);
            string bookPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Books",
                "Alices Adventures in Wonderland - Lewis Carroll.txt");

            (int totalWords, int totalCharacters) = student.CalculateBookStats(bookPath);

            int expectedTotalWords = 29594;
            int expectedTotalCharacters = 132854;

            student.Book.Display($"Total Words: {totalWords}, Total Characters: {totalCharacters}");
            Assert.IsTrue(totalWords.Equals(expectedTotalWords) && totalCharacters.Equals(expectedTotalCharacters));
        }


        [TestMethod]
        public void TestStudentSearchBookTermTwoCities()
        {
            var student = new Student(_studentTextFileBook);
            string bookPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Books",
                "A Tale of Two Cities - Charles Dickens.txt");
            string searchTerm = "revolution";

            int count = student.SearchBookTerm(searchTerm, bookPath);
            int expectedCount = 14;

            student.Book.Display($"The word '{searchTerm}' appears {count} times.");
            Assert.AreEqual(count, expectedCount);
        }

        [TestMethod]
        public void TestBusinessAnalystSearchTopWordsTwoCities()
        {
            var businessAnalyst = new BusinessAnalyst(_businessAnalystTextFileBook);
            string bookPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Books",
                "A Tale of Two Cities - Charles Dickens.txt");

            List<string> topWords = businessAnalyst.SearchBookTopWords(bookPath);
            businessAnalyst.Book.Display($"[{string.Join(", ", topWords)}]"  ?? $"[]");

            Assert.IsTrue(topWords.Count > 0);
        }

        [TestMethod]
        public void TestBusinessAnalystSearchTopWordsAlice()
        {
            var businessAnalyst = new BusinessAnalyst(_businessAnalystTextFileBook);
            string bookPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Books",
                "Alices Adventures in Wonderland - Lewis Carroll.txt");

            List<string> topWords = businessAnalyst.SearchBookTopWords(bookPath);
            businessAnalyst.Book.Display($"[{string.Join(", ", topWords)}]" ?? $"[]");

            Assert.IsTrue(topWords.Count > 0);
        }

    }
}