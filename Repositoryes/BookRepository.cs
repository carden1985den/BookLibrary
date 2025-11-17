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
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Remove(Book book)
        {
            try
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override List<Book> SelectAll()
        {
            return db.Books.ToList();
        }

        public override Book? SelectById(int id)
        {
            return db.Books.FirstOrDefault(u => u.Id == id);
        }

        public bool Update(Book book)
        {
            try
            {
                db.Books.Update(book);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
