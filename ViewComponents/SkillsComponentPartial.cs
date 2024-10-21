using KisiselSitem.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class SkillsComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();

            return View(values);
        }
    }
}
