using Microsoft.AspNetCore.Mvc;
using TrabalhosMoveisMVC.Models.ModelsView;

namespace TrabalhosMoveisMVC.Controllers
{
    public class MoveisController : Controller
    {
        public IActionResult ListaMoveis()
        {
            List<ItemModelView> itemModelViews = new List<ItemModelView>();
            itemModelViews.Add(new ItemModelView("Mesa", "False"));
            itemModelViews.Add(new ItemModelView("nome", "true"));

            return View(itemModelViews);
        }
    }
}
