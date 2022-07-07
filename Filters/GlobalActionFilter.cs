using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class GlobalActionFilter : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) {
        Console.WriteLine("Global:     OnActionExecuting");
    }

    public void OnActionExecuted(ActionExecutedContext context) {
        Console.WriteLine("Global:     OnActionExecuted");
    }
}