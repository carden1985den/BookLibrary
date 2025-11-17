using BookLibrary.Configuration;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookLibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        // таблица с отношением пользователей и взятых ими книг
        public DbSet<RentedBook> BookRents { get; set; }

        public BookLibraryContext(bool isNew = false)
        {
            if (isNew)
            {
                Database.EnsureDeleted();
            }

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfig.SqlConnectionString);
        }
    }
}
