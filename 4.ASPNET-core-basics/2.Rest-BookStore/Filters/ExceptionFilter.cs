using _2.Rest_BookStore.Filters.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _2.Rest_BookStore.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandlers;
        public ExceptionFilter()
            => _exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>
            {
                { typeof(InvalidOperationException), HandleInvalidOperationException },
                { typeof(UnauthorizedAccessException), HandleUnauthorizedAccessException },
                { typeof(NotFoundException), HandleNotFoundException },
                { typeof(ForbiddenException), HandleForbiddenAccessException },
                { typeof(ValidationException), HandleValidationAccessException },
            };
        public override void OnException(ExceptionContext context)
        {
            HandleException(context);
            base.OnException(context);
        }

        private void HandleException(ExceptionContext context)
        {
            Type type = context.Exception.GetType();

            if (_exceptionHandlers.TryGetValue(type, out Action<ExceptionContext>? value))
            {
                value.Invoke(context);
                return;
            }

            if (!context.ModelState.IsValid)
            {
                HandleInvalidModelStateException(context);
                return;
            }
        }

        private static void HandleInvalidModelStateException(ExceptionContext context)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "The rest of the exception",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new BadRequestObjectResult(details);

            context.ExceptionHandled = true;
        }

        private void HandleInvalidOperationException(ExceptionContext context)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Title = "Bad Request",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new ObjectResult(details);

            context.ExceptionHandled = true;
        }

        private void HandleNotFoundException(ExceptionContext context)
        {
            var details = new ProblemDetails()
            {
                Status = StatusCodes.Status404NotFound,
                Title = "The specified resource was not found.",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new NotFoundObjectResult(details);

            context.ExceptionHandled = true;
        }

        private void HandleUnauthorizedAccessException(ExceptionContext context)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status401Unauthorized,
                Title = "Unauthorized",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new ObjectResult(details)
            {
                StatusCode = StatusCodes.Status401Unauthorized
            };

            context.ExceptionHandled = true;
        }

        private void HandleForbiddenAccessException(ExceptionContext context)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status403Forbidden,
                Title = "Forbidden",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new ObjectResult(details)
            {
                StatusCode = StatusCodes.Status403Forbidden
            };

            context.ExceptionHandled = true;
        }
        
        private void HandleValidationAccessException(ExceptionContext context)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Title = "Bad request",
                Detail = context.Exception.Message,
                Instance = context.HttpContext.Request.Path
            };

            context.Result = new ObjectResult(details)
            {
                StatusCode = StatusCodes.Status403Forbidden
            };

            context.ExceptionHandled = true;
        }
    }
}