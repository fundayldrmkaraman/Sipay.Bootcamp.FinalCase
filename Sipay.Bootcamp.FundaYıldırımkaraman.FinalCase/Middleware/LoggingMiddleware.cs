using System.Text;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Gelen isteğin başlık (header) bilgilerini loglama
            StringBuilder logMessage = new StringBuilder();
            logMessage.Append($"Request Method: {context.Request.Method}, ");
            logMessage.Append($"Request Path: {context.Request.Path}, ");
            logMessage.Append($"Request Headers: {context.Request.Headers}");

            // Loglama
            using (StreamWriter writer = new StreamWriter("request_logs.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} - {logMessage}");
            }

            // Sonraki middleware'e ilerle
            await _next(context);
        }
    }
    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
