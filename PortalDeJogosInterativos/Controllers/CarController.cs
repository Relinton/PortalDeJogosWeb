using Microsoft.AspNetCore.Mvc;

namespace PortalDeJogosInterativos.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
