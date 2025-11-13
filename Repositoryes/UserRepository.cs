using BookLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class UserRepository : Repository<User>
    {
        public override User SelectById(int id)
        {
            return db.Users.First(u => u.Id == id);
        }

        //public User SelectByEmail(string email)
        //{
        //    return db.Users.First(u => u.Id == id);
        //}

        public override List<User> SelectAll()
        {
            return db.Users.ToList();
        }

        public override bool Add(string name, string email)
        {
            try
            {
                // проверяем существование пользователя по EMAIL, если нет такого, создаём пользователя 
                if ((db.Users.FirstOrDefault(u => u.Email == email)) is null)
                {
                    db.Users.Add(new User() { Name = name, Email = email });
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public override bool RemoveById(int id)
        {
            return true;
        }

        public bool UpdateNameById()
        {
            return true;
        }
    }
}
