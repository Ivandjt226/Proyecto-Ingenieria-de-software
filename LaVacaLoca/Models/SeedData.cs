using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LaVacaLoca.Data;
using System;
using System.Linq;
namespace LaVacaLoca.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LaVacaLocaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LaVacaLocaContext>>()))
            {
                // Look for any movies.
                if (context.Prenda.Any())
                {
                    return;   // DB has been seeded
                }

                context.Prenda.AddRange(
                    new Prenda
                    {
                        Nombre = "When Harry Met Sally",
                        FechaDeLanzamiento = DateTime.Parse("1989-2-12"),
                        TipoDePrenda = "Romantic Comedy",
                        Talla = "S, M, L",
                        Precio = 7.99M
                    },
                    new Prenda
                    {
                        Nombre = "When Harry Met Sally",
                        FechaDeLanzamiento = DateTime.Parse("1989-2-12"),
                        TipoDePrenda = "Romantic Comedy",
                        Talla = "S, M, L",
                        Precio = 7.99M
                    },

                    new Prenda
                    {
                        Nombre = "When Harry Met Sally",
                        FechaDeLanzamiento = DateTime.Parse("1989-2-12"),
                        TipoDePrenda = "Romantic Comedy",
                        Talla = "S, M, L",
                        Precio = 7.99M
                    },

                    new Prenda
                    {
                        Nombre = "When Harry Met Sally",
                        FechaDeLanzamiento = DateTime.Parse("1989-2-12"),
                        TipoDePrenda = "Romantic Comedy",
                        Talla = "S, M, L",
                        Precio = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
