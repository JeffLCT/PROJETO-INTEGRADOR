using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    public class usuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
