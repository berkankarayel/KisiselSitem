using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
              return View();
        }
    }
}
