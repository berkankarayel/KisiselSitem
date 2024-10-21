using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
