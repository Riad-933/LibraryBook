using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_08._04
{
    internal class Library
    {
        Book[] books = new Book[] { };

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public Book[] FindAllBooksByName(string name)
        {
            Book[] booksByName = new Book[] { };
            bool check = false;

            if (books.Length > 0)
            {
                foreach (Book book in books)
                {
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].Name == name)
                        {
                            check = true;
                            Array.Resize(ref booksByName, booksByName.Length + 1);
                            booksByName[books.Length - 1] = book;
                        }
                        else
                        {
                            Console.WriteLine("Now there is not any book with this name at the library");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Now there is not any book at the library");
            }
            return books;
        }
        public Book[] RemoveAllBookByName(string name)
        {
            Book[] remBooks = new Book[] { };

            if (books.Length > 0)
            {
                foreach (Book book in books)
                {
                    if (book.Name == name)
                    {
                        Array.Resize(ref remBooks, remBooks.Length + 1);
                        remBooks[remBooks.Length - 1] = book;
                    }
                    else
                    {
                        Console.WriteLine("Array updated");
                    }
                }
            }
            return remBooks;
        }
        public Book[] SearchBooks(string name, string authorName, int pageCount)
        {
            Book[] searchBooks = new Book[] { };
            bool check = false;

            if (books.Length > 0)
            {
                foreach (Book book in books)
                {
                    if (book.Name == name||book.AuthorName == authorName||book.PageCount == pageCount)
                    {
                        check = true;
                        Array.Resize(ref searchBooks, searchBooks.Length + 1);
                        searchBooks[searchBooks.Length - 1] = book;
                    }
                }
                if (check)
                {
                    Console.WriteLine($"Now there is not any book with this name or authorname or pagecount at the library");
                }
            }
            else
            {
                Console.WriteLine("Now there is not any book at the library");
            }

            return searchBooks;
        }
    }
}