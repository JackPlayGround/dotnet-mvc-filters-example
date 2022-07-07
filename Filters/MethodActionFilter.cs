using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class MethodActionFilter : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) {
        Console.WriteLine("Method:     OnActionExecuting");
    }

    public void OnActionExecuted(ActionExecutedContext context) {
        Console.WriteLine("Method:     OnActionExecuted");
    }
}