using BookLibrary.Models;
using BookLibrary.Repositoryes;

namespace BookLibrary
{
    public class RentRepository : RepositoryConnection
    {
        UserRepository userRepository = new UserRepository();
        BookRepository bookRepository = new BookRepository();
        public bool RentBook(int userId, int bookId)
        {
            User user = userRepository.SelectById(userId);
            Book book = bookRepository.SelectById(bookId);

            if (user is not null && book is not null)
            {
                BookRent bookRent = new BookRent() { UserId = user.Id, BookId = book.Id, RentDate = new DateTime() };
                db.BookRents.Add(bookRent);

                return true;
            }

            return false;
        }
    }
}