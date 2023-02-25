using Microsoft.AspNetCore.Mvc;

namespace ELSADemo.Controllers
{
    public class ELSADashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
