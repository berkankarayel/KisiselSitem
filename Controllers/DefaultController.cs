using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
// IActionsResult geriye view dönememi sağlıyor.