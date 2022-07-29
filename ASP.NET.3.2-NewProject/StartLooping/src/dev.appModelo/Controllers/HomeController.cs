using System;
using dev.appModelo.Data;
using Microsoft.AspNetCore.Mvc;
namespace dev.appModelo.Controllers
{
    public class HomeController: Controller
    {
        private IPedidoRepository _pedidoRepository;


        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }


        [Route("")]
        [Route("StartLooping")]

        public IActionResult Index()        
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
