namespace my_books_asp_net.Data.Models;

public class Publisher
{
    public int Id { get; set; }
    public required string Name { get; set; }

    // Navigation properties
    public List<Book>? Books { get; set; } = [];
}
