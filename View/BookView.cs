using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.View
{
    public class BookView
    {
        public void Menu(BookRequestProcessing bookRequestProcessing)
        {
            
            while (true)
            {
                Console.WriteLine("1 - Показать всех книги");
                Console.WriteLine("2 - Найти книгу по ID");
                Console.WriteLine("3 - Изменить год книги");
                Console.WriteLine("4 - Добавить книгу");
                Console.WriteLine("5 - Удалить книгу");
                Console.WriteLine("0 - Назад");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            bookRequestProcessing.SelectAllBooks();
                            break;
                        }
                    case "2":
                        {
                            bookRequestProcessing.SelectBookById();
                            break;
                        }
                    case "3":
                        {
                            bookRequestProcessing.UpdateBookYearById();
                            break;
                        }
                    case "4":
                        {
                            bookRequestProcessing.AddBook();
                            break;
                        }
                    case "5":
                        {
                            bookRequestProcessing.RemoveBook();
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
