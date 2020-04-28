using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTorneio.Models;

namespace ApiTorneio.Models
{
    public class ApiTorneioContext : DbContext
    {
        public ApiTorneioContext (DbContextOptions<ApiTorneioContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTorneio.Models.Jogador> Jogador { get; set; }

        public DbSet<ApiTorneio.Models.Time> Time { get; set; }
    }
}
