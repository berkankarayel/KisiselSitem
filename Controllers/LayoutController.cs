using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
