using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDentista1.Models;

namespace MvcDentista1.Data
{
    public class MvcDentista1Context : DbContext
    {
        public MvcDentista1Context (DbContextOptions<MvcDentista1Context> options)
            : base(options)
        {
        }

        public DbSet<MvcDentista1.Models.Paciente> Paciente { get; set; }
        public DbSet<MvcDentista1.Models.Diente> Diente { get; set; }

        public DbSet<MvcDentista1.Models.Turno> Turno { get; set; }
    }
}
