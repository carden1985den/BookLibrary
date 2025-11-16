using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class BookRent
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public int UserId { get; set; }
        List <User> Users { get; set; }
        public int BookId { get; set; }
        List <Book> Books { get; set; }

    }
}
