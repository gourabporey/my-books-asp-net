public class Author
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Book_Author> BooksAuthors { get; set; } = [];
}
