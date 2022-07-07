using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

// GlobalResultFilter.cs
public class MethodResultFilter : Attribute, IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        Console.WriteLine("Method:     OnResultExecuting");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        Console.WriteLine("Method:     OnResultExecuted");
    }
}