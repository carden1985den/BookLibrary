using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    public class BookRepository : Repository <Book>
    {
        public bool Add(Book book)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Book SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
