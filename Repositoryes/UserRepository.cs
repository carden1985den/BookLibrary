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

        public List<User> SelectAll()
        {
            return db.Users.ToList();
        }

        public override bool Add()
        {
            return true;
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
