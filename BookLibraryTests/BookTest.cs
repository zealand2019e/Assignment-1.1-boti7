using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookLibrary;

namespace BookLibraryTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookConstructor()
        {
            Book b = new Book("Title", "Author", 11, "0123456789012");

            Assert.AreEqual(b.Title, "Title");
            Assert.AreEqual(b.Author, "Author");
            Assert.AreEqual(b.PageNum, 11);
            Assert.AreEqual(b.Isbn13, "0123456789012");
        }
        
        [TestMethod]
        public void Title()
        {
            Book b = new Book();

            b.Title = "Test title";

            Assert.AreEqual(b.Title, "Test title");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TitleInvalid()
        {
            Book b = new Book();

            b.Title = "T";
        }
        
        [TestMethod]
        public void Author()
        {
            Book b = new Book();

            b.Author = "Test author";

            Assert.AreEqual(b.Author, "Test author");
        }
        
        [TestMethod]
        public void PageNumLow()
        {
            Book b = new Book();

            b.PageNum = 11;

            Assert.AreEqual(b.PageNum, 11);
        }
        
        [TestMethod]
        public void PageNumHigh()
        {
            Book b = new Book();

            b.PageNum = 1000;

            Assert.AreEqual(b.PageNum, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PageNumInvalidLow()
        {
            Book b = new Book();

            b.PageNum = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PageNumInvalidHigh()
        {
            Book b = new Book();

            b.PageNum = 1001;
        }
        
        [TestMethod]
        public void Isbn13Valid()
        {
            Book b = new Book();

            b.Isbn13 = "0123456789012";

            Assert.AreEqual(b.Isbn13, "0123456789012");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13InvalidShort()
        {
            Book b = new Book();

            b.Isbn13 = "012345678901";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13InvalidLong()
        {
            Book b = new Book();

            b.Isbn13 = "01234567890123";
        }
    }
}
