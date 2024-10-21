using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
