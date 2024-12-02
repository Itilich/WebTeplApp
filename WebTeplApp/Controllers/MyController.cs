using Microsoft.AspNetCore.Mvc;

namespace WebTeplApp.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
    }
}
