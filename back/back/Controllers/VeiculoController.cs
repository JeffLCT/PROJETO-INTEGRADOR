using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    public class veiculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
