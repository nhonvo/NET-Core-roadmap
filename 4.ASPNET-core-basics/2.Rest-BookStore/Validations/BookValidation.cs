using FluentValidation;

namespace _2.Rest_BookStore.Validations
{
    public class BookValidation : AbstractValidator<Book>
    {
        public BookValidation()
        {
            RuleFor(x=>x.Name)
                .MaximumLength(10)
                .WithMessage("Max length must be lower than 10")
                .WithErrorCode("bad_request");
        }
    }
}