using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
