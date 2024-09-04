namespace my_books_asp_net.Data.Models;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsRead { get; set; }
    public DateTime? DateRead { get; set; }
    public int? Rating { get; set; }
    public string CoverUrl { get; set; }
    public string Author { get; set; }
    public DateTime DateAdded { get; set; }
    public string Genre { get; set; }
}