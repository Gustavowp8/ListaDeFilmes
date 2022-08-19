using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeuFilme.Models;

namespace MeuFilme.Data
{
    public class MeuFilmeContext : DbContext
    {
        public MeuFilmeContext (DbContextOptions<MeuFilmeContext> options)
            : base(options)
        {
        }

        public DbSet<MeuFilme.Models.Filmes> Filmes { get; set; } = default!;
    }
}
