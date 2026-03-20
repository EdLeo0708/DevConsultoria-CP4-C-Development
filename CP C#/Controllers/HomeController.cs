using Microsoft.AspNetCore.Mvc;
using CP_C_.Models;
using System.Collections.Generic;

namespace CP_C_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var problemas = new List<Problema>()
            {
                new Problema{Id=1, Nome="Bug no Sistema", Descricao="Erro no login", TempoResposta="24h"},
                new Problema{Id=2, Nome="API não funciona", Descricao="Erro na API", TempoResposta="48h"},
                new Problema{Id=3, Nome="Banco lento", Descricao="Consulta demorando", TempoResposta="72h"}
            };

            return View(problemas);
        }

        [HttpPost]
        public IActionResult Solicitar(string nome, string email, string problema)
        {
            TempData["msg"] = "Solicitação enviada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}