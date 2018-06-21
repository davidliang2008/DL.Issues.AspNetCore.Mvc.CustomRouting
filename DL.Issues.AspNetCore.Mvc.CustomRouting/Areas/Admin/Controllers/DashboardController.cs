using Microsoft.AspNetCore.Mvc;

namespace DL.Issues.AspNetCore.Mvc.CustomRouting.Areas.Admin.Controllers
{
    public class DashboardController : AdminControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}