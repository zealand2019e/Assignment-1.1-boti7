using System;

namespace BookLibrary
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pagenum;
        private string _isbn13;

        public string Title
        {
            get => _title;
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Title must be at least 2 characters long");

                _title = value;
            }
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int PageNum
        {
            get => _pagenum;
            set
            {
                if (value <= 10 || value > 1000)
                    throw new ArgumentOutOfRangeException("Page number must be (10,1000]");

                _pagenum = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length != 13)
                    throw new ArgumentException("ISBN must be 13 chars long");
                
                _isbn13 = value;
            }
        }

        public Book() {}

        public Book(string title, string author, int pagenum, string isbn13)
        {
            Title = title;
            Author = author;
            PageNum = pagenum;
            Isbn13 = isbn13;
        }
    }
}
