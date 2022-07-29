using Microsoft.AspNetCore.Mvc;

namespace dev.appModelo.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Produtos/Busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
