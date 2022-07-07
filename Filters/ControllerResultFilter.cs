using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

// GlobalResultFilter.cs
public class ControllerResultFilter : Attribute, IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        Console.WriteLine("Controller: OnResultExecuting");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        Console.WriteLine("Controller: OnResultExecuted");
    }
}