using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookLibrary.View
{
    public class RequestView
    {
        public void Menu()
        {
            UserRepository userRepository = new UserRepository();
            BookRepository bookRepository = new BookRepository();
            RentRepository rentRepository = new RentRepository();

            while (true)
            {
                Console.WriteLine("1 - Получать список книг определенного жанра и вышедших между определенными годами");
                Console.WriteLine("2 - Получать количество книг определенного автора в библиотеке");
                Console.WriteLine("3 - Получать количество книг определенного жанра в библиотеке");
                Console.WriteLine("4 - Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке");
                Console.WriteLine("5 - Получать булевый флаг о том, есть ли определенная книга на руках у пользователя");
                Console.WriteLine("6 - Получать количество книг на руках у пользователя");
                Console.WriteLine("7 - Получение последней вышедшей книги");
                Console.WriteLine("8 - Получение списка всех книг, отсортированного в алфавитном порядке по названию");
                Console.WriteLine("9 - Получение списка всех книг, отсортированного в порядке убывания года их выхода");
                Console.WriteLine("0 - Выход в предыдущее меню");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Введите жанр");
                            string gener = Console.ReadLine();

                            Console.WriteLine("Введите начальную дату");
                            int startDate = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите конечную дату");
                            int endDate = int.Parse(Console.ReadLine());

                            var books = bookRepository.SelectAll().Where(b => b.Genre == gener & b.Year > startDate & b.Year < endDate);
                            foreach (var book in books)
                            {
                                Console.WriteLine($"{book.Title} {book.Genre} {book.Year}");
                            }

                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите автора");
                            string author = Console.ReadLine();
                            Book book = bookRepository.SelectAll().FirstOrDefault(u => u.Author.Contains(author));

                            if (book != null)
                            {
                                var count = bookRepository.SelectAll().Count(b => b.Author.Contains(book.Author));
                                Console.WriteLine($"Количество книг автора \"{book.Author}\" = {count}");
                            }

                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Введите жанр");
                            string gener = Console.ReadLine();

                            var count = bookRepository.SelectAll().Count(b => b.Genre == gener);
                            Console.WriteLine($"Книг жанра \"{gener}\" = {count}");

                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Введите автора");
                            string author = Console.ReadLine();

                            Console.WriteLine("Введите название книги");
                            string title = Console.ReadLine();

                            bool exist = bookRepository.SelectAll().Any(b => b.Title == title & b.Author == author);
                            Console.WriteLine(exist);

                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Введите название книги");
                            string title = Console.ReadLine();
                            Book book = bookRepository.SelectAll().FirstOrDefault(b => b.Title.Contains(title));

                            if (book is not null)
                            {
                                RentedBook rent = rentRepository.SelectRentByBookId(book.Id);
                                if (rent is not null)
                                {
                                    Console.WriteLine(true);
                                }
                            }

                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Введите id пользователя");
                            int id = int.Parse(Console.ReadLine());
                            
                            User user = userRepository.SelectById(id);
                            int count = rentRepository.SelectRentedBookByUserId(id).Count();
                            
                            Console.WriteLine($"У пользователя {user.Name} на руках {count} книг");
                            
                            // Выход в предыдущее емню
                            Application.ExitPreviousMenu();
                            break;
                        }
                    case "7":
                        {
                            Book books = bookRepository.SelectAll().OrderByDescending(b => b.Year).FirstOrDefault();
                            Console.WriteLine(books.Year);
                            break;
                        }
                    case "8":
                        {
                            var books = bookRepository.SelectAll().OrderBy(b => b.Title);
                            foreach (var book in books)
                            {
                                Console.WriteLine(book.Title);
                            }
                            break;
                        }
                    case "9":
                        {
                            var books = bookRepository.SelectAll().OrderByDescending(b => b.Year);
                            foreach (var book in books)
                            {
                                Console.WriteLine($"{book.Title} {book.Year}");
                            }
                            break;
                        }
                    case "0":
                        {
                            return;
                        }
                }
            }
        }
    }
}
