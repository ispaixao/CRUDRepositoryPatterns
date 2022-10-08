using Microsoft.EntityFrameworkCore;
using TesteCRUDRepositoryPatterns.Model;

namespace TesteCRUDRepositoryPatterns.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Produto> Produtos { get; set; }
    }
}
