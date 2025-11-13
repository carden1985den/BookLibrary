using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model
{
    public class Book
    {
        public int id {  get; set; }
        public string Title {  get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
