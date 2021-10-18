using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace IteratorsAndComparators
{
    public class BookEnumerator : Exception, IEnumerator<Book>
    {
        private List<Book> _books;
        private int index;

        public BookEnumerator(IEnumerable<Book> books)
        {
            this.Reset();
            this._books = new List<Book>(books);
        }

        public bool MoveNext()
        {
            index++;
            return index < _books.Count;
        }

        public void Reset() => index = -1;
        public Book Current => _books[index];

        object? IEnumerator.Current => Current;

        public void Dispose(){}
        
    }
}