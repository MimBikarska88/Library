using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year , params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }

        public int CompareTo(Book other)
        {
            if (other == null)
            {
                return 1;
            }else if (object.ReferenceEquals(this, other))
            {
                return 0;
            }else if (this.Year.CompareTo(other.Year) == 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            else
            {
                return this.Year.CompareTo(other.Year);
            }
        }
    }
}