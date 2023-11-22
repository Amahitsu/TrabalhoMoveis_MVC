using Microsoft.AspNetCore.Mvc;

namespace TrabalhosMoveisMVC.Controllers
{
    public class MoveisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
