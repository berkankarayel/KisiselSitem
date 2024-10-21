using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class NavbarComponentParcala: ViewComponent

    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
