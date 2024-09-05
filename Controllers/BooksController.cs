namespace my_books_asp_net.Controllers;

using Microsoft.AspNetCore.Mvc;
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
    public IActionResult AddBook([FromBody] BookVM book) => Ok(_booksService.AddBook(book));

    [HttpGet]
    public IActionResult GetAllBooks() => Ok(_booksService.GetAllBooks());

    [HttpGet("{id}")]
    public IActionResult GetBookById(int id) => Ok(_booksService.GetBookById(id));

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] BookVM book)
    {
        var updatedBook = _booksService.UpdateBook(id, book);
        return Ok(updatedBook);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        _booksService.DeleteBook(id);
        return Ok();
    }
}
