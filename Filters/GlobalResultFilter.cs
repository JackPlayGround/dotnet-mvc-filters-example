using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

// GlobalResultFilter.cs
public class GlobalResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        Console.WriteLine("Gobal:      OnResultExecuting");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        Console.WriteLine("Global:     OnResultExecuted");
    }
}