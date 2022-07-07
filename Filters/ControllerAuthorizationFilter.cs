using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcFilter.Filters;

public class ControllerAuthorizationFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("Controller: OnAuthorization");
    }
}