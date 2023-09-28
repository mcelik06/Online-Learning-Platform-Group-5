using Microsoft.AspNetCore.Mvc;

namespace SampleMonitoringProj.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
