using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class GlobalAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("Global:     OnAuthorization");
    }
}