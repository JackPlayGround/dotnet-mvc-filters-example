using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class GlobalResourceFilter : IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("Global:     OnResourceExecuting");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("Global:     OnResourceExecuted");
    }
}