using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    public class EstacionamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
