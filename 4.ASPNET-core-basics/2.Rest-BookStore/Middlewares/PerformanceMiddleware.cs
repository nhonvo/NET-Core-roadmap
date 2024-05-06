
using System.Diagnostics;

namespace _2.Rest_BookStore.Middlewares
{
    public class PerformanceMiddleware(ILoggerFactory logger, Stopwatch stopwatch) : IMiddleware
    {
        private readonly Stopwatch _stopwatch = stopwatch;
        private readonly ILogger _logger = logger.CreateLogger<PerformanceMiddleware>();

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _stopwatch.Restart();
            _stopwatch.Start();

            await next(context);

            _stopwatch.Stop();
            TimeSpan timeTaken = _stopwatch.Elapsed;

            _logger.LogInformation("Time taken: {timeTaken}", timeTaken.ToString(@"m\:ss\.fff"));
        }
    }
}