using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class RentRequestProcessing
    {
        UserRepository userRepository = new UserRepository();
        BookRepository bookRepository = new BookRepository();
        RentRepository rentRepository = new RentRepository();

        public void RentBook(int userId, int bookId)
        {
            User user = userRepository.SelectById(userId);
            Book book = bookRepository.SelectById(bookId);

            // Получаем все ранее арендованные книги для указанного полдьзователя
            IEnumerable<RentedBook> rentedBook = rentRepository.SelectRentedBookByUserId(user.Id);

            // Проверяем, не была ли книга выданга ранее этому же пользователю
            if (rentedBook.FirstOrDefault() != null)
            {
                Console.WriteLine("Книга была ранее выдана этому пользователю");
                // Выходим в предыдущее емню
                Application.ExitPreviousMenu();
                return;
            }

            // если в БД найдены и пользователь и книга, выдаём пользователю книгу
            if (user is not null && book is not null)
            {
                bool result = rentRepository.AddRendedBook(user, book);
                if (result)
                {
                    Console.WriteLine($"Пользователь {user.Name} получил книгу {book.Title}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка выдачи книги, проверьте корректность ID пользователя, или корректность ID книги");
            }
        }

        public void ReturnBook(int id)
        {
            IEnumerable<RentedBook> rentedBooks = rentRepository.SelectRentedBookByUserId(id);

            if (rentedBooks.Count() == 0)
            {
                Console.WriteLine("На пользователе не числится книг");

                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
                return;
            }

            Console.WriteLine($"Id\tTitle\tAuthor");
            foreach (var rentedBook in rentedBooks)
            {
                Book book = bookRepository.SelectById(rentedBook.BookId);
                Console.WriteLine($"{book.Id}\t{book.Title}\t{book.Author}");
            }

            Console.WriteLine();
            Console.WriteLine("Введите Id книги для возврата");
            int bookId = int.Parse(Console.ReadLine());

            bool result = rentRepository.DeleteRentedBook(rentRepository.SelectRentByBookId(bookId));

            if (result)
            {
                Console.WriteLine("Книга возвращена");

                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine("Ошибка возврата книги");

                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
            }
        }
    }
}
