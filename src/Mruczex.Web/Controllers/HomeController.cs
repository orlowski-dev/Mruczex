using Microsoft.AspNetCore.Mvc;

namespace Mruczex.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
