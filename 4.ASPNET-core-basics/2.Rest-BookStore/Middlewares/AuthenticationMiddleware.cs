namespace _2.Rest_BookStore.Middlewares
{
    public class AuthenticationMiddleware : IMiddleware
    {
        /// <summary>
        /// Authentication middleware base on header try get values Authorization(FOR REFERENCE)
        /// </summary>
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!context.Request.Headers.TryGetValue("Authorization", out var authorizationHeader))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: Authorization header not found.");
                return;
            }

            if (!IsAuthenticated(authorizationHeader))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: Invalid credentials.");
                return;
            }

            await next(context);
        }

        private static bool IsAuthenticated(string authorizationHeader) => authorizationHeader == "Bearer my-secret-token";
    }
}