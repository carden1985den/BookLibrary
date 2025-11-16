using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class UserRequestProcessing
    {
        UserRepository userRepository = new UserRepository();
        public void ShowAllUsers()
        {
            Console.WriteLine("Список всех пользователей");

            Console.WriteLine("id\tname\temail");
            Console.WriteLine();
            foreach (User user in userRepository.SelectAll())
            {
                Console.WriteLine($"{user.Id}\t{user.Name}\t\t{user.Email}");
            }
        }
        public void GetUserById(int id)
        {
            Console.WriteLine("Поиск пользователя по ID");
            User result = userRepository.SelectById(id);

            if (result is not null)
            {
                Console.WriteLine(result.Name);
            }
            else
            {
                Console.WriteLine($"Пользователь с ID: {id} не найден");
            }
        }
        public void AddUser(string name, string email)
        {
            if (userRepository.SelectByEmail(email) is null)
            {
                bool result = userRepository.Add(new User() { Name = name, Email = email });

                if (result)
                {
                    Console.WriteLine("Пользователь добавлен");
                }
                else
                {
                    Console.WriteLine($"Ошибка добавления пользователя");
                }
            }
            else
            {
                Console.WriteLine($"Пользователь с указанным Email существует");
            }
        }
        public void RemoveUser(int id)
        {
            bool result = userRepository.Remove(id);
            if (result)
            {
                Console.WriteLine("Пользователь удалён");
            }
            else
            {
                Console.WriteLine("Ошибка удаления пользователя");
            }
        }
        public void UpdateUserById() { }



    }
}
