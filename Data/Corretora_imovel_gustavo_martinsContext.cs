using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corretora_imovel_gustavo_martins.Models;

namespace Corretora_imovel_gustavo_martins.Data
{
    public class Corretora_imovel_gustavo_martinsContext : DbContext
    {
        public Corretora_imovel_gustavo_martinsContext (DbContextOptions<Corretora_imovel_gustavo_martinsContext> options)
            : base(options)
        {
        }

        public DbSet<Corretora_imovel_gustavo_martins.Models.Usuario> Usuario { get; set; } = default!;
    }
}
