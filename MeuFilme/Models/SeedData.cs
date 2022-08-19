using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeuFilme.Data;
using System;
using System.Linq;


namespace MeuFilme.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MeuFilmeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MeuFilmeContext>>()))
            {
                // Look for any movies.
                if (context.Filmes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Filmes.AddRange(
                    new Filmes
                    {
                        Titulo = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Preco = 7.99M
                    }
                );
                context.SaveChanges();
            }

        }
    }
}
