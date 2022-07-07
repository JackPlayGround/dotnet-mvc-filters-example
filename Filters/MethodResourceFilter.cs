using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class MethodResourceFilter : Attribute, IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("Method:     OnResourceExecuting");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("Method:     OnResourceExecuted");
    }
}