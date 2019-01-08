using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_Becasoft.DAL
{
    public class BecasoftContext : DbContext
    {
        public BecasoftContext() 
            : base("BecasoftContext")
        {
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
