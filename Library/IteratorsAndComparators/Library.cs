using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book> 
    {
        private List<Book> books;

        public Library(params Book[]books)
        {
            this.books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new BookEnumerator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

       
    }
}