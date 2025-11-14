using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class BookRegistration
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int UserId { get; set; }
        List <User> Users { get; set; }
        public int BookId { get; set; }
        List <Book> Books { get; set; }

    }
}
