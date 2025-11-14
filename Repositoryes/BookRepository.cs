using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    public class BookRepository : Repository<Book>
    {
        public override bool Add(Book book)
        {
            throw new NotImplementedException();
        }

        public override bool Remove()
        {
            throw new NotImplementedException();
        }

        public override List<Book> SelectAll()
        {
            throw new NotImplementedException();
        }

        public override Book SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
