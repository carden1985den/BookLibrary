using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    /// <summary>
    /// Обработка запросов пользвоателя по БД Users
    /// </summary>
    public class UserRequestProcessing
    {
        UserRepository userRepository = new UserRepository();

        /// <summary>
        /// Просмотр всех пользователей
        /// </summary>
        public void SelectAllUsers()
        {
            Console.WriteLine("Список всех пользователей");

            Console.WriteLine("id\tname\temail");
            Console.WriteLine();
            foreach (User user in userRepository.SelectAll())
            {
                Console.WriteLine($"{user.Id}\t{user.Name}\t\t{user.Email}");
            }

            Application.ExitPreviousMenu();
        }

        /// <summary>
        /// Получение пользователя по ID
        /// </summary>
        public void SelectUserById()
        {
            Console.WriteLine("Введите Id пользователя");
            int userId = int.Parse(Console.ReadLine());

            User user = userRepository.SelectById(userId);

            if (user is null)
            {
                Console.WriteLine("Пользователь не найден");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
                return;
            }

            Console.WriteLine($"Id\tName\tEmail");
            Console.WriteLine($"{user.Id}\t{user.Name}\t{user.Email}");

            // Выход в предыдущее емню
            Application.ExitPreviousMenu();
        }

        /// <summary>
        /// Добавление пользователя в базу
        /// </summary>
        public void AddUser()
        {
            Console.WriteLine("Введите имя нового пользователя");
            var userName = Console.ReadLine();

            Console.WriteLine("Введите email нового пользователя");
            var userEmail = Console.ReadLine();

            User user = userRepository.SelectByEmail(userEmail);

            if (user is not null)
            {
                Console.WriteLine("Указанный пользователь существует");

                // Выход в предыддущее меню
                Application.ExitPreviousMenu();
                return;
            }

            bool result = userRepository.Add(new User() { Name = userName, Email = userEmail });

            if (result)
            {
                Console.WriteLine("Пользователь добавлен");

                // Выход в предыддущее меню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine($"Ошибка добавления пользователя");

                // Выход в предыддущее меню
                Application.ExitPreviousMenu();
            }
        }

        /// <summary>
        /// Удаление пользхователя из БД по ID
        /// </summary>
        public void RemoveUser()
        {
            Console.WriteLine("Введите Id пользователя");
            int userId = int.Parse(Console.ReadLine());

            User user = userRepository.SelectById(userId);

            if (user is null)
            {
                Console.WriteLine("Пользователь не найден");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
                return;
            }

            bool result = userRepository.Remove(user);
            if (result)
            {   
                Console.WriteLine("Пользователь удалён");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine("Ошибка удаления пользователя");

                // Выход в предыдущее емню
                Application.ExitPreviousMenu();
            }
        }

        /// <summary>
        /// Изменение пользователя по ID
        /// </summary>
        public void UpdateUserNameById()
        {
            Console.WriteLine("Введите Id пользователя");
            int userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите новое имя пользователя");
            string newName = Console.ReadLine();

            User user = userRepository.SelectById(userId);

            if (user == null)
            {
                Console.WriteLine("Пользователь не найден");

                // возврат в предыдущее меню
                Application.ExitPreviousMenu();
                return;
            }

            if (user.Name == newName)
            {
                Console.WriteLine("Имя пользователя совпадает с текущим");

                // возврат в предыдущее меню
                Application.ExitPreviousMenu();
                return;
            }

            user.Name = newName;

            bool result = userRepository.UpdateNameById(user);

            if (result)
            {
                Console.WriteLine("Пользователь изменен");

                // возврат в предыдущее меню
                Application.ExitPreviousMenu();
            }
            else
            {
                Console.WriteLine("Ошибка изменения пользователя");

                // возврат в предыдущее меню
                Application.ExitPreviousMenu();
            }
        }
    }
}
