using Microsoft.AspNetCore.Mvc;
using dev.appModelo.Data;
using dev.appModelo.Models;
using System;
using System.Linq;

namespace dev.appModelo.Controllers { 
    public class TestCrudController : Controller
    {
        // adicionando injeção de dependência
        private readonly MeuDbContext _contexto;

        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            //atribuindo novo aluno na variavel 
            var item = new Produto
            {
                Nome = "Mouse",
                Marca = "Corasair",
                DataProduto = DateTime.Now,
                Valor = 150,
                EmailFabricante = "corsair@gmail.com"
            };

            //adicionando aluno dentro da memoria do db context com entity framework
            _contexto.Produtos.Add(item);
            //salvar o aluno na base de dados 
            _contexto.SaveChanges();

            //buscando aluno por id
            var produto1 = _contexto.Produtos.Find(item.Id);
            //buscando unico aluno por email
            var produto2 = _contexto.Produtos.FirstOrDefault(a => a.EmailFabricante == "eduardo@gmail.com");
            // buscando coleção de alunos por email
            var produto3 = _contexto.Produtos.Where(a => a.EmailFabricante == "eduardo@gmail.com");

            var aluno3 = _contexto.Produtos.Where(a => a.EmailFabricante == "eduardo@gmail.com");

            //atualizando o Aluno da variável "aluno" para joão
            produto1.Nome = "João";
            _contexto.Produtos.Update(item);
            _contexto.SaveChanges();

            // remove o aluno da instancia aluno 
            _contexto.Produtos.Remove(item);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}