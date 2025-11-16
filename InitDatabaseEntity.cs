using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public static class InitDatabaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db">Database context</param>
        /// <param name="init">True or False, init data or not</param>
        public static void Now(BookLibraryContext db, bool init = false)
        {
            if (init)
            {
                // add users
                db.Users.AddRange(
                    new User() { Name = "Денис", Email = "napalmded@mail.ru" },
                    new User() { Name = "Иван", Email = "vanya@mail.ru" },
                    new User() { Name = "Екатерина", Email = "" },
                    new User() { Name = "Сергей", Email = "serg@gmail.ru" },
                    new User() { Name = "Анастасия", Email = "nastya@yandex.ru" },
                    new User() { Name = "Станислав", Email = "stas@msn.com" },
                    new User() { Name = "Роман", Email = "romka@mail.ru" },
                    new User() { Name = "Алексей", Email = "elex@gmail.ru" },
                    new User() { Name = "Кристина", Email = "kris@ya.ru" },
                    new User() { Name = "Наталья", Email = "natka@work.com" }
                    );
                // add books
                db.Books.AddRange(
                    new Book() { Title = "Война и мир", Author = "Лев Толстой", Year = 1867 },
                    new Book() { Title = "Искусство программирования", Author = "Дональд Кнут", Year = 2011 },
                    new Book() { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Year = 1967 },
                    new Book() { Title = "Гарри Поттер и Философский камень", Author = "Дж. К. Роулинг", Year = 1997 },
                    new Book() { Title = "1984", Author = "Джордж Оруэлл", Year = 1949 },
                    new Book() { Title = "Код да Винчи", Author = "Дэн Браун", Year = 2003 },
                    new Book() { Title = "Сумеречная сага. Затмение", Author = "Стефани Майер", Year = 2007 },
                    new Book() { Title = "Девушка с татуировкой дракона", Author = "Стиг Ларссон", Year = 2005 },
                    new Book() { Title = "Марсианин", Author = "Энди Вейер", Year = 2011 },
                    new Book() { Title = "Преступление и наказание", Author = "Фёдор Достоевский", Year = 1866 }
                    );
            }
            db.SaveChanges();
        }
    }
}
