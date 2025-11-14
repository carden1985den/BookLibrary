using BookLibrary.Models;
using BookLibrary.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class UserView
    {
        UserRepository userRepository = new UserRepository();
        public void GetUser()
        {
            Console.WriteLine("Список всех пользователей");
            foreach (User user in userRepository.SelectAll())
            {
                Console.WriteLine($"{user.Name}");
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
            var result = userRepository.Add(new User() { Name = name, Email = email });

            if (result)
            {
                Console.WriteLine("Пользователь добавлен");
            }
            else
            {
                Console.WriteLine($"Ошибка добавления пользователя");
            }
        }
        public void DeleteUser() { }
        public void UpdateUserById() { }



    }
}
