using LojaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaMVC.NovaPasta1
{
    public class BancoContext : DbContext

    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ProdutoModel> ProdutoDB { get; set; }

    }
}
