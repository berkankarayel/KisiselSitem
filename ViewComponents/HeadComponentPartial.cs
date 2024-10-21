using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
   
    public class HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            
           return View(); 
        }
    }
}
