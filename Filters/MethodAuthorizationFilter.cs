using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class MethodAuthorizationFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("Method:     OnAuthorization");
    }
}