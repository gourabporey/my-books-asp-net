public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book_Author> BooksAuthors { get; set; }
}
