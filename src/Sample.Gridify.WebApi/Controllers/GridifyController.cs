using Gridify;
using Microsoft.AspNetCore.Mvc;
using Sample.Gridify.Core.Context;
using Sample.Gridify.Core.Extensions;

namespace Sample.Gridify.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GridifyController : ControllerBase
{
    private readonly BookContext _context;

    public GridifyController(BookContext context)
    {
        _context = context;
    }

    [HttpGet("books")]
    public IActionResult GetBooks([FromQuery]GridifyQuery model)
    {
        if (!_context.Books.Any())
        {
            _context.Books.AddRange(SeedsExtensions.ReturnBooks());
            _context.SaveChanges();
        }

        var result = _context.Books.GridifyQueryable(model);

        return Ok(result);
    }
}
