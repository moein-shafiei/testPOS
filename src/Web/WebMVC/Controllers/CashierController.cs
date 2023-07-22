using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class CashierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
