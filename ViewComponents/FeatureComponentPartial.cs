using KisiselSitem.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents
{
    public class FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
