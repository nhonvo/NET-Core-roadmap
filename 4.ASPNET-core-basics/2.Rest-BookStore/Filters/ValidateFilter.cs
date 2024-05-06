using _2.Rest_BookStore.Filters.Exceptions;
using _2.Rest_BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _2.Rest_BookStore.Filters
{
    public class ValidateFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                if (context.ModelState.ContainsKey("FluentValidationError"))
                {
                    var modelState = context.ModelState["FluentValidationError"]!.Errors[0].Exception;
                    context.Result = new BadRequestObjectResult(((ValidationException)modelState!).ErrorResponse);
                }
                else
                {
                    var errors = context.ModelState.Keys
                                .SelectMany(key => context.ModelState[key]!.Errors)
                                    .Select(x => new Error("app_name.bad_request",
                                        x.ErrorMessage))
                                .ToList();
                    var modelState = context.ModelState.ToList();
                    for (int i = 0; i < errors.Count; i++)
                    {
                        errors[i].AddErrorProperty(
                            new ErrorProperty(
                                modelState[i].Key,
                                modelState[i].Value.AttemptedValue.ToString() ?? ""
                                )
                        );
                    }
                    context.Result = new BadRequestObjectResult(
                        new ErrorResponse
                        {
                            Errors = errors
                        }
                    );
                }
            }
            await next();
        }
    }
}