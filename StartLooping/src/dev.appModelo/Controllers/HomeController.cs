using System;
using Microsoft.AspNetCore.Mvc;
namespace dev.appModelo.Controllers
{
    public class HomeController: Controller
    {
        [Route("")]
        [Route("StartLooping")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
