using Microsoft.AspNetCore.Mvc;
using my_books_asp_net.Data.Services;
using my_books_asp_net.Data.ViewModels;

namespace my_books_asp_net.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PublishersController : ControllerBase
{
    private PublishersService _publishersService;

    public PublishersController(PublishersService publishersService)
    {
        _publishersService = publishersService;
    }

    [HttpGet]
    public IActionResult GetAllPublishers()
    {
        return Ok(_publishersService.GetAllPublishers());
    }

    [HttpPost]
    public IActionResult AddPublisher([FromBody] PublisherVM publisher)
    {
        return Ok(_publishersService.AddPublisher(publisher));
    }
}
