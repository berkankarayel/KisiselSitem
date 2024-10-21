using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents.LayoutViewComponents
{
	public class LayoutHeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
