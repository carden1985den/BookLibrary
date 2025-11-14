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
        public override User SelectById(int id)
        {
            return base.db.Users.FirstOrDefault(u => u.Id == id);
        }

        public override List<User> SelectAll()
        {
            return db.Users.ToList();
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

        public override bool Remove()
        {
            return true;
        }

        public bool UpdateNameById()
        {
            return true;
        }
    }
}
