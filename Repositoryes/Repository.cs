using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public abstract class Repository <T>
    {
        public BookLibraryContext db = new BookLibraryContext(true);
        public abstract T SelectById(int id);
        public abstract List<T> SelectAll();
        public abstract bool Add();
        public abstract bool Remove();
    }
}
