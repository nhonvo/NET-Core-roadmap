using _2.Rest_BookStore.Models;

namespace _2.Rest_BookStore.Filters.Exceptions;

public sealed class ValidationException(ErrorResponse errorResponse) : Exception
{
    public ErrorResponse ErrorResponse { get; private set; } = errorResponse;
}
