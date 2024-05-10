using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dependency_Injection_Pattern.Models;

namespace Dependency_Injection_Pattern.Controllers;

public class HomeController : Controller
{
    //Dependency Injected Based Controller
    private readonly ILog _logger;

    public HomeController(ILog logger)
    {
        _logger = logger;
    }

    public IActionResult Index([FromServices]ILog logger) //Dependency Injected Based Action
    {
        string model = logger.Log(); //log function is a test function and returns string 
        return View("Index", model);
    }

    public IActionResult Privacy()
    {
        string model = _logger.Log(); //using dependency injection based controller
        return View("Privacy", model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}