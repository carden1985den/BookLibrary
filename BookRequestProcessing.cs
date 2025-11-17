using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookRequestProcessing
    {
        //private UserRepository userRepository = new UserRepository();
        private BookRepository bookRepository = new BookRepository();
        public void SelectAllBooks() {

            Console.WriteLine("Список всех книг");

            Console.WriteLine("ID\tTitle\tAuthor\tYear");
            Console.WriteLine();
            foreach (Book book in bookRepository.SelectAll())
            {
                Console.WriteLine($"{book.Id}\t{book.Title}\t{book.Author}\t{book.Year}");
            }

            // Выход в предыдущее меню
            Application.ExitPreviousMenu();
        }
        public void SelectBookById() {
            Console.WriteLine("Введите Id книги");
            int bookId = int.Parse(Console.ReadLine());

            Book book = bookRepository.SelectById(bookId);

            if (book is null)
            {
                Console.WriteLine("Книга не найден");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
                return;
            }

            Console.WriteLine($"Id\tTitle\tAuthor\tYear");
            Console.WriteLine($"{book.Id}\t{book.Title}\t{book.Author}\t{book.Year}");

            // Выход в предыдущее емню
            Application.ExitPreviousMenu();
        }
        public void AddBook() {
            Console.WriteLine("Введите название новой книги");
            var bookTitle = Console.ReadLine();

            Console.WriteLine("Введите автора новой книги");
            var bookAuthor = Console.ReadLine();

            Console.WriteLine("Введите год выпуска новой книги");
            var bookYear = int.Parse(Console.ReadLine());

            bool result = bookRepository.Add(new Book() { Title = bookTitle, Author = bookAuthor, Year = bookYear });

            if (result)
            {
                Console.WriteLine("Книга добавлена");

                // Выход в предыддущее меню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine($"Ошибка добавления книги");

                // Выход в предыддущее меню
                Application.ExitPreviousMenu();
            }
        }
        public void RemoveBook() {

            Console.WriteLine("Введите Id книги");
            int bookId = int.Parse(Console.ReadLine());

            Book book = bookRepository.SelectById(bookId);

            if (book is null)
            {
                Console.WriteLine("Книга не найден");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
                return;
            }

            bool result = bookRepository.Remove(book);
            if (result)
            {
                Console.WriteLine("Книгна удалена удалён");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine("Ошибка удаления книги");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
            }

        }
        public void UpdateBookYearById()
        {
            Console.WriteLine("Введите Id книги");
            int bookId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите новый год книги");
            int bookYear = int.Parse(Console.ReadLine());

            // Ищем книгу по ID
            Book book = bookRepository.SelectById(bookId);

            // Если книга по ID не найдена, выходим предыдущее емню
            if (book == null)
            {
                Console.WriteLine("Книга не найдена");
                
                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
                return;
            }

            book.Year = bookYear;

            bool result = bookRepository.Update(book);

            if (result)
            {
                Console.WriteLine("Год книги изменен");
                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine("Ошибка изменения года книги");
                // Выход в предыдущее меню
                Application.ExitPreviousMenu();
            }
        }
    }
}
