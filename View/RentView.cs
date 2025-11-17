using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.View
{
    public class RentView
    {
        public void Menu(RentRequestProcessing rentRequestProcessing)
        {
            while (true)
            {

                Console.WriteLine("1 - Взять книгу");
                Console.WriteLine("2 - Вернуть книгу");
                Console.WriteLine("0 - Выход в предыдущее меню");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Введите Id пользователя");
                            int userId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите Id гниги");
                            int bookId = int.Parse(Console.ReadLine());

                            rentRequestProcessing.RentBook(userId, bookId);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите Id пользователя");
                            int userId = int.Parse(Console.ReadLine());
                            rentRequestProcessing.ReturnBook(userId);
                            

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


