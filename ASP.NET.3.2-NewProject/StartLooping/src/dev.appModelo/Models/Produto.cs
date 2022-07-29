using System;
namespace dev.appModelo.Models
{
    public class Produto
    {
        //configurando para que o id seja gerado randomicamente através do guid
        public Produto(){
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string EmailFabricante { get; set; }
        public float Valor { get; set; }
        public DateTime DataProduto { get; set; }
        
        
      
    }
}

