using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MeuApp.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponents : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponents()
        {
            ItensCarrinho = 12;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinho);
        }
    }
}