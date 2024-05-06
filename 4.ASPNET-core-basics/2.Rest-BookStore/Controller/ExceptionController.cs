using _2.Rest_BookStore.Filters;
using _2.Rest_BookStore.Filters.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace _2.Rest_BookStore.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExceptionController : ControllerBase
    {
        [HttpGet("not-found")]
        public IActionResult NotFoundException()
        {
            throw new NotFoundException("not found");
        }

        [HttpGet("Invalid-Operation")]
        public IActionResult InvalidOperationException()
        {
            throw new InvalidOperationException("Invalid-Operation");
        }

        [HttpGet("Unauthorized")]
        public IActionResult UnauthorizedException()
        {
            throw new UnauthorizedAccessException("Unauthorized");
        }

        [HttpGet("Forbidden")]
        public IActionResult Forbidden()
        {
            throw new ForbiddenException("Forbidden");
        }

        [HttpGet("validate-filter")]
        public IActionResult ValidateFilter()
        {
            return Ok("validate filter");
        }

    }
}