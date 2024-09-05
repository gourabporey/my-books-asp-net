namespace my_books_asp_net.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using my_books_asp_net.Data.Models;
using my_books_asp_net.Data.Services;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private BooksService _booksService;

    public BooksController(BooksService booksService)
    {
        _booksService = booksService;
    }

    [HttpPost]
    public Book AddBook([FromBody] BookVM book)
    {
        return _booksService.AddBook(book);
    }
}