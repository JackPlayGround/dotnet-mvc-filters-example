using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class ControllerResourceFilter : Attribute, IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("Controller: OnResourceExecuting");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("Controller: OnResourceExecuted");
    }
}