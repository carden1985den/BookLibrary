using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    public class UserRepository : RepositoryConnection //, IRepository<User>
    {
        public User? SelectById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> SelectAll()
        {
            return db.Users.ToList();
        }

        public User? SelectByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }
        public bool Add(User user)
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

        public bool Remove(int id)
        {
            try
            {
                db.Users.Remove(SelectById(id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNameById()
        {
            return true;
        }
    }
}
