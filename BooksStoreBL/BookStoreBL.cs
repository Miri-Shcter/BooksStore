using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        //1
        public void GetBooksOn30() 
        {
            var books = ListOfBooks.Where(book => book.Price > 30);
            return books;
        }
        //2
        public void OrderBooks()
        {
            foreach (var book in ListOfBooks.OrderBy(book => book.Id))
                Console.WriteLine(book.Name);
        }
        //3
        public void OnlyComics() 
        {
            foreach (var book in ListOfBooks.OrderBy(book => book.IsComics))
                Console.WriteLine(book.Price);
        }
        //4
        public void NamesOfBooks()
        {
            foreach (var book in ListOfBooks.OrderBy(book => book.MinAge <9 && book.MaxAge>=9))
                Console.WriteLine(book.Name);
        }

    }
}
