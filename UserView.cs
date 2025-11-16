using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class UserView
    {
        public void Menu(UserRequestProcessing userRequestProcessing)
        {
            while (true)
            {
                //Console.Clear();

                Console.WriteLine("1 - Показать всех пользователей");
                Console.WriteLine("2 - Найти пользователя по ID");
                Console.WriteLine("3 - Добавить пользователя");
                Console.WriteLine("4 - Удалить пользователя");
                Console.WriteLine("0 - Назад");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            userRequestProcessing.ShowAllUsers();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите Id пользователя");

                            bool result = int.TryParse(Console.ReadLine(), out int id);

                            if (result)
                                userRequestProcessing.GetUserById(id);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Введите имя");
                            var name = Console.ReadLine();

                            Console.WriteLine("Введите email");
                            var email = Console.ReadLine();

                            userRequestProcessing.AddUser(name, email);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Введите Id пользователя");

                            bool result = int.TryParse(Console.ReadLine(), out int id);

                            if (result)
                                userRequestProcessing.RemoveUser(id);
                            break;
                        }
                    case "0":
                        return;
                }
            }
        }
    }
}
