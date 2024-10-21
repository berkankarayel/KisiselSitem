using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.ViewComponents.LayoutViewComponents
{
	public class SideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
		return View();
		}
	}
}
