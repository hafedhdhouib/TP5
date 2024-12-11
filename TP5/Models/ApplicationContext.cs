using Microsoft.EntityFrameworkCore;

namespace TP5.Models
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext( DbContextOptions options):base(options) { }
        public DbSet<Categorie> Categorias { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
