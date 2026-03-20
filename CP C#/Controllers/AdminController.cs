using Microsoft.AspNetCore.Mvc;

namespace CP_C_.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Painel()
        {
            return View();
        }

        public IActionResult Aprovar()
        {
            ViewBag.Msg = "Solicitação aprovada e enviada ao Dev!";
            return View("Painel");
        }

        public IActionResult Reprovar()
        {
            ViewBag.Msg = "Solicitação recusada.";
            return View("Painel");
        }
    }
}