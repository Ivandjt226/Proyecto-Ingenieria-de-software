#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaVacaLoca.Models;

namespace LaVacaLoca.Data
{
    public class LaVacaLocaContext : DbContext
    {
        public LaVacaLocaContext (DbContextOptions<LaVacaLocaContext> options)
            : base(options)
        {
        }

        public DbSet<LaVacaLoca.Models.Prenda> Prenda { get; set; }
    }
}
