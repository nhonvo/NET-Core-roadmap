namespace _2.Rest_BookStore.Filters.Exceptions;

public sealed class ForbiddenException : Exception
{
    public ForbiddenException() : base()
    {
    }
    public ForbiddenException(string message)
    : base(message)
    {
    }

    public ForbiddenException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ForbiddenException(string name, object key)
        : base($"Entity {name} ({key}) was not found.")
    {
    }
}
