namespace my_books_asp_net.Data.Services;

using System.Collections.Generic;
using my_books_asp_net.Data;
using my_books_asp_net.Data.Models;

public class BooksService
{
    private AppDbContext _context;

    public BooksService(AppDbContext context)
    {
        _context = context;
    }

    public Book AddBook(BookVM book)
    {
        var _book = new Book()
        {
            Title = book.Title,
            Description = book.Description,
            Author = book.Author,
            Genre = book.Genre,
            IsRead = book.IsRead,
            DateRead = book.DateRead,
            DateAdded = book.DateAdded,
            Rating = book.Rating,
            CoverUrl = book.CoverUrl,
        };
        _context.Books.Add(_book);
        _context.SaveChanges();

        return _book;
    }

    public List<Book> GetAllBooks() => _context.Books.ToList();

    public Book? GetBookById(int id) => _context.Books.FirstOrDefault(b => b!.Id == id);

    public Book? UpdateBook(int id, BookVM book)
    {
        var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == id);

        if (bookToUpdate != null)
        {
            bookToUpdate.Title = book.Title;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Genre = book.Genre;
            bookToUpdate.IsRead = book.IsRead;
            bookToUpdate.DateRead = book.DateRead;
            bookToUpdate.Rating = book.Rating;
            bookToUpdate.CoverUrl = book.CoverUrl;

            _context.SaveChanges();
        }

        return bookToUpdate;
    }
}
