using Microsoft.EntityFrameworkCore;
using my_books_asp_net.Data.Models;

namespace my_books_asp_net.Data;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }
}