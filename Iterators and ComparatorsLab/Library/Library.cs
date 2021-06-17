using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        { 
            private readonly List<Book> books;
            private int currIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public bool MoveNext()
            {
                return ++this.currIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currIndex = -1;
            }

            public Book Current => this.books[this.currIndex];

            object? IEnumerator.Current => this.Current;

            public void Dispose() {}
        }
    }
}
