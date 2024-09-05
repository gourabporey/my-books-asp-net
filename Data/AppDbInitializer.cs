using my_books_asp_net.Data;
using my_books_asp_net.Data.Models;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>()!;
            if (!context.Books.Any())
            {
                context.AddRange(
                    new Book()
                    {
                        Title = "Book1",
                        Description = "Book1 Description",
                        Author = "Gourab",
                        IsRead = false,
                        CoverUrl = "https://..",
                        DateAdded = DateTime.Now,
                        Genre = "Tragedy"
                    },
                    new Book()
                    {
                        Title = "Book2",
                        Description = "Book2 Description",
                        Author = "Sourov",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-20),
                        Rating = 5,
                        CoverUrl = "https://..",
                        DateAdded = DateTime.Now,
                        Genre = "Tragedy"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}