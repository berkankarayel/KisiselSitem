using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class TestimonialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
