using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace MyFirstWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Write exception to a log file
            File.AppendAllText("logs.txt", $"{DateTime.Now}: {context.Exception}\n");

            context.Result = new ObjectResult("An error occurred. Please try again.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true; // ✅ Mark as handled
        }
    }
}
