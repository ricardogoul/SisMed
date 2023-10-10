using Microsoft.AspNetCore.Mvc;
using SisMed.Application.AppService;
using SisMed.Application.Interfaces;

namespace SisMed.Controllers.Medico
{
    public class MedicoController : Controller
    {
        private const int TAMANHO_PAGINA = 10;
        public readonly IMedicoAppService _app;

        public MedicoController(IMedicoAppService app)
        {
            _app = app;
        }

        public IActionResult Index(string filtro, int page = 1)
        {
            var vm = _app.ListaMedico(filtro);
            ViewBag.Filtro = filtro;
            ViewBag.Pagina = page;
            ViewBag.TotalPaginas = Math.Ceiling((decimal)vm.Count()/TAMANHO_PAGINA);

            return View(vm.Skip((page - 1) * TAMANHO_PAGINA).Take(TAMANHO_PAGINA));
        }

        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
