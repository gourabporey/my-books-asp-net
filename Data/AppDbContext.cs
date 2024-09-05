using Microsoft.EntityFrameworkCore;
using my_books_asp_net.Data.Models;

namespace my_books_asp_net.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Book_Author>()
            .HasOne(b => b.Book)
            .WithMany(ba => ba.BooksAuthors)
            .HasForeignKey(bi => bi.BookId);

        modelBuilder
            .Entity<Book_Author>()
            .HasOne(b => b.Author)
            .WithMany(ba => ba.BooksAuthors)
            .HasForeignKey(bi => bi.AuthorId);
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book_Author> Books_Authors { get; set; }
}
