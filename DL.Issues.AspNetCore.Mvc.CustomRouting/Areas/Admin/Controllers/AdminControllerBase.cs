using Microsoft.AspNetCore.Mvc;

namespace DL.Issues.AspNetCore.Mvc.CustomRouting.Areas.Admin.Controllers
{
    // If you comment the [Area] attribute out, everything works.
    // But if you have it on, previous routings with area="" will not work!
    [Area("admin")]
    public abstract class AdminControllerBase : Controller
    {
    }
}
