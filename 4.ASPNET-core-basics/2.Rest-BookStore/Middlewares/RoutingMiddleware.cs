namespace _2.Rest_BookStore.Middlewares
{
    public class RoutingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Path.StartsWithSegments("/custom"))
            {
                await context.Response.WriteAsync("Handled by custom middleware");
            }
            else
            {
                await next(context);
            }
        }
    }
}