using KisiselSitem.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class ExperienceComponent:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
