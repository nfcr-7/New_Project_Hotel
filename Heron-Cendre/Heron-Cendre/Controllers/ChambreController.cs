using Microsoft.AspNetCore.Mvc;

namespace Heron_Cendre.Controllers
{
    public class ChambreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
