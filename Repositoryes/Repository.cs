using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    public abstract class Repository<T>
    {
        protected BookLibraryContext db = new BookLibraryContext();
        public abstract T? SelectById(int id);
        public abstract List<T> SelectAll();
        public abstract bool Add(T obj);
        public abstract bool Remove(T obj);
    }
}
