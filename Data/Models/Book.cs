namespace my_books_asp_net.Data.Models;

class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsRead { get; set; }
    public DateTime? DateRead { get; set; }
    public int? Rating { get; set; }
    public required string CoverUrl { get; set; }
    public required string Author { get; set; }
    public DateTime DateAdded { get; set; }
    public required string Genre { get; set; }
}