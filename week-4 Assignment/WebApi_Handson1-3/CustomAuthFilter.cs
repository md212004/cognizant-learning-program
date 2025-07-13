using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MyFirstWebAPI.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Check if Authorization header is present
            if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                //  Return 400 Bad Request (not an exception)
                context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
                return;
            }

            // Get the Authorization header value
            var authHeader = context.HttpContext.Request.Headers["Authorization"].ToString();

            // Check if the token contains "Bearer"
            if (!authHeader.StartsWith("Bearer"))
            {
                // Return 400 Bad Request (not an exception)
                context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
                return;
            }

            base.OnActionExecuting(context); // Proceed if token is valid
        }
    }
}
