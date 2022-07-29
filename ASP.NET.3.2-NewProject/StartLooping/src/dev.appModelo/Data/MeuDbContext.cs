using dev.appModelo.Models;
using Microsoft.EntityFrameworkCore;

namespace dev.appModelo.Data
{
    public class MeuDbContext : DbContext
    {

        public MeuDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

    }

}



