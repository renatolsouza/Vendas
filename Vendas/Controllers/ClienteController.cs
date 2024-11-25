using Microsoft.AspNetCore.Mvc;

namespace Vendas.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
