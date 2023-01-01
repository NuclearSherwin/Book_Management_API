using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}