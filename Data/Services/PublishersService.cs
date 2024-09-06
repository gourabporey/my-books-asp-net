using my_books_asp_net.Data.Models;
using my_books_asp_net.Data.ViewModels;

namespace my_books_asp_net.Data.Services;

public class PublishersService
{
    private AppDbContext _context;

    public PublishersService(AppDbContext context)
    {
        _context = context;
    }

    public Publisher AddPublisher(PublisherVM publisher)
    {
        var _publisher = new Publisher() { Name = publisher.Name };
        _context.Publishers.Add(_publisher);
        _context.SaveChanges();
        return _publisher;
    }

    public List<Publisher> GetAllPublishers()
    {
        return _context.Publishers.ToList();
    }
}
