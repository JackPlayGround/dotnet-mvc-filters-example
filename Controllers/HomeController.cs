using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcFilter.Models;
using MvcFilter.Filters;

namespace MvcFilter.Controllers;

[ControllerResourceFilter,
 ControllerAuthorizationFilter,
 ControllerActionFilter,
 ControllerResultFilter]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [MethodResourceFilter,
     MethodAuthorizationFilter,
     MethodActionFilter,
     MethodResultFilter]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
