using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperenceList()
        {
            return View();
        }
    }
}
