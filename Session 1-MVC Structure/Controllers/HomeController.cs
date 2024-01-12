using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_1.Models;

namespace Sample;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

}
