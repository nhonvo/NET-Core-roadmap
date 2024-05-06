namespace _2.Rest_BookStore.Models
{
    public class ErrorResponse
    {
        public IEnumerable<Error> Errors = [];
        public ErrorResponse()
        {

        }
        public ErrorResponse(IEnumerable<Error> errors)
        {
            Errors = errors;
        }

    }
}