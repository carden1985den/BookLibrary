using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.View
{
    public class UserView
    {
        public void Menu(UserRequestProcessing userRequestProcessing)
        {
            while (true)
            {
                Console.WriteLine("1 - Показать всех пользователей");
                Console.WriteLine("2 - Найти пользователя по ID");
                Console.WriteLine("3 - Изменить имя пользователя");
                Console.WriteLine("4 - Добавить пользователя");
                Console.WriteLine("5 - Удалить пользователя");
                Console.WriteLine("0 - Назад");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            // Показать всех пользователей
                            userRequestProcessing.SelectAllUsers();
                            break;
                        }
                    case "2":
                        {
                            // Показать пользователя по Id
                            userRequestProcessing.SelectUserById();
                            break;
                        }
                    case "3":
                        {
                            // Обновление имени пользователя по ID
                            userRequestProcessing.UpdateUserNameById();
                            break;
                        }
                    case "4":
                        {
                            // Добавление нового пользователя
                            userRequestProcessing.AddUser();
                            break;
                        }
                    case "5":
                        {
                            // Удаление пользователя
                            userRequestProcessing.RemoveUser();
                            break;
                        }
                    case "0":
                        return;
                }
            }
        }
    }
}
