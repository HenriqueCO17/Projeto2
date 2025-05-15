using Microsoft.AspNetCore.Mvc;

namespace Projeto2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
