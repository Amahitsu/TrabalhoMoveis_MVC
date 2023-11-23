using Microsoft.AspNetCore.Mvc;
using TrabalhosMoveisMVC.Models.ModelsView;

namespace TrabalhosMoveisMVC.Controllers
{
    public class MoveisController : Controller
    {
        public IActionResult ListaMoveis()
        {
            List<ItemModelView> itemModelViews = new List<ItemModelView>();
            itemModelViews.Add(new ItemModelView("Mesa", true));
            itemModelViews.Add(new ItemModelView("Cadeira", false));
            itemModelViews.Add(new ItemModelView("Cama", false));
            itemModelViews.Add(new ItemModelView("Sofá", true));

            return View(itemModelViews);
        }
    }
}
