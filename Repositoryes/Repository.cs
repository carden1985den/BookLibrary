using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositoryes
{
    interface IRepository<T>
    {
        public T? SelectById(int id);
        public List<T> SelectAll();
        public bool Add(T obj);
        public bool Remove(int id);
    }
}
