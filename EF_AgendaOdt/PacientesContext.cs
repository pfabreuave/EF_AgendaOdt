using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AgendaOdt
{
    internal class PacientesContext : DbContext
    {
        public PacientesContext() : base("PgPacientes")
        {
        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
