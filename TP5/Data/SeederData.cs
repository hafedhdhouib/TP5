using TP5.Models;

namespace TP5.Data
{
    public class SeederData
    {
        public static void seed (IApplicationBuilder applicationBuilder)
        {
            var serviceScoop = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScoop.ServiceProvider.GetService<ApplicationContext>();

            if (!context.Categorias.Any())
            {
                context.Categorias.AddRange(
                    new Categorie() { Designation = "Accessoire" },
                    new Categorie() { Designation = "Televiseur" }
                 );
                context.SaveChanges();
            }
        }
    }
}
