using Microsoft.AspNetCore.Mvc;
using TrabalhosMoveisMVC.Models.ModelsView;

namespace TrabalhosMoveisMVC.Controllers
{
    public class MoveisController : Controller
    {
        public IActionResult ListaMoveis()
        {
            ItemModelView itemModelView = new ItemModelView();
            itemModelView.nomeMoveis = "cadeira";
            itemModelView.checkMoveis = "true";

            return View(itemModelView);
        }
    }
}
