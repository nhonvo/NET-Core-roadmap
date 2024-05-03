using Microsoft.AspNetCore.Mvc;

namespace _1.MVC.Views.Components
{
    public class SearchBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}