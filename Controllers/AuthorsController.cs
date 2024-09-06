using Microsoft.AspNetCore.Mvc;
using my_books_asp_net.Data.Services;
using my_books_asp_net.Data.ViewModels;

namespace my_books_asp_net.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private AuthorsService _authorsService;

    public AuthorsController(AuthorsService authorsService)
    {
        _authorsService = authorsService;
    }

    [HttpGet]
    public IActionResult GetAllAuthors()
    {
        return Ok(_authorsService.GetAllAuthors());
    }

    [HttpPost]
    public IActionResult AddAuthor([FromBody] AuthorVM author)
    {
        return Ok(_authorsService.AddAuthor(author));
    }
}
