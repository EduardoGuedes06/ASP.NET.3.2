using Microsoft.AspNetCore.Mvc;
using MeuApp.Models;

namespace MeuApp.Controllers
{
    [Route("Formulario")]
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {





            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {

            if (ModelState.IsValid)
            {
                //Retorna     
            }




            return View();
        }

    }
}
