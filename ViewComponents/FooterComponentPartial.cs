using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
