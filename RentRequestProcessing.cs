using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class RentRequestProcessing
    {
        RentRepository rentRepository = new RentRepository();
        public bool RentBook()
        {
            Console.WriteLine("Введите Id пользователя");
            int userId = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите Id гниги");
            int bookId = int.Parse(Console.ReadLine());

            rentRepository.RentBook(userId, bookId);
            return true; 
        }
    }
}
