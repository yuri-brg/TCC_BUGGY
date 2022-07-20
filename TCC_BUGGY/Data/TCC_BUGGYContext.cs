using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCC_BUGGY.Models;

namespace TCC_BUGGY.Data
{
    public class TCC_BUGGYContext : DbContext
    {
        public TCC_BUGGYContext (DbContextOptions<TCC_BUGGYContext> options)
            : base(options)
        {
        }

        public DbSet<TCC_BUGGY.Models.Usuario> Usuario { get; set; }

        public DbSet<TCC_BUGGY.Models.Atendimento> Atendimento { get; set; }

        public DbSet<TCC_BUGGY.Models.Cliente> Cliente { get; set; }

        public DbSet<TCC_BUGGY.Models.Ocorrencia> Ocorrencia { get; set; }
    }
}
