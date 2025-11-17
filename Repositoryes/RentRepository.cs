using BookLibrary.Models;
using BookLibrary.Repositoryes;
using Microsoft.IdentityModel.Tokens;

namespace BookLibrary
{
    /// <summary>
    /// Аренда книги, берем ИД пользователя и ИД книги в вносим в табилцу аренды
    /// </summary>
    public class RentRepository
    {
        public bool AddRendedBook(User user, Book book)
        {
            using (var db = new BookLibraryContext())
            {
                try
                {
                    RentedBook bookRent = new RentedBook() { UserId = user.Id, BookId = book.Id, RentDate = (new DateTime()).Date };
                    db.BookRents.Add(bookRent);
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return true;
                }
            }
        }

        public IEnumerable<RentedBook> SelectRentedBookByUserId(int id)
        {
            using (var db = new BookLibraryContext())
            {
                return db.BookRents.Where(u => u.UserId == id).ToList();
            }
        }
        public bool DeleteRentedBook(RentedBook rentedBooks)
        {
            using (var db = new BookLibraryContext())
            {
                try
                {
                    db.Remove(rentedBooks);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public RentedBook SelectRentByBookId(int bookId)
        {
            using (var db = new BookLibraryContext())
            {
                return db.BookRents.FirstOrDefault(b => b.BookId == bookId);
            }
        }
    }
}