using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_08._04
{
    internal class Book
    {
        private int _no;
        public int No
        {
            get { return _no; }
            set
            {
                if (value > 0)
                {
                    _no = value;
                }
            }
        }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        private int _pageCount;
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value > 0)
                {
                    _pageCount = value;
                }
            }
        }

        public Book(int no, string name, string authorName, int pageCount)
        {
            _no++;
            _no = no;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
