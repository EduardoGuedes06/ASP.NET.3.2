using System;
using Microsoft.AspNetCore.Mvc;
namespace dev.appModelo.Controllers
{
    [Route("")]
    [Route("StartLoping")]
    public class HomeController: Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
    }
}
