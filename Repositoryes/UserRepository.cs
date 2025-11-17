using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    public class UserRepository : Repository<User>
    {
        public override User? SelectById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public override List<User> SelectAll()
        {
            return db.Users.ToList();
        }

        public User? SelectByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }
        public override bool Add(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Remove(User user)
        {
            try
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Обновление имени пользвоателя по ID
        /// </summary>
        /// <returns> true or false </returns>
        public bool UpdateNameById(User user)
        {
            try
            {
                db.Users.Update(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
