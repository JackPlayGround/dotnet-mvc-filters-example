using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class ControllerActionFilter : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) {
        Console.WriteLine("Controller: OnActionExecuting");
    }

    public void OnActionExecuted(ActionExecutedContext context) {
        Console.WriteLine("Controller: OnActionExecuted");
    }
}