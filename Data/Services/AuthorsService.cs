using my_books_asp_net.Data.ViewModels;

namespace my_books_asp_net.Data.Services;

public class AuthorsService
{
    private AppDbContext _context;

    public AuthorsService(AppDbContext context)
    {
        _context = context;
    }

    public Author AddAuthor(AuthorVM author)
    {
        var _author = new Author() { Name = author.Name };
        _context.Authors.Add(_author);
        _context.SaveChanges();
        return _author;
    }

    public List<Author> GetAllAuthors()
    {
        return _context.Authors.ToList();
    }
}
