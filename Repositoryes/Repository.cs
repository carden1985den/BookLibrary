using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    interface IRepository<T>
    {
        public BookLibraryContext db = new BookLibraryContext(true);
        public abstract T SelectById(int id);
        public abstract List<T> SelectAll();
        public abstract bool Add(string name, string email);
        public abstract bool RemoveById(int id);
    }
}
