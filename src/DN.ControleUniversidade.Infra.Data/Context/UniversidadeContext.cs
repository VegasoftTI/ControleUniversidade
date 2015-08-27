using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Infra.Data.Context
{
    public class UniversidadeContext: BaseDbContext
    {
        public UniversidadeContext()
            : base("UniversidadeContext")
        {
            //Configuration.AutoDetectChangesEnabled = false;
            //Configuration.EnsureTransactionsForFunctionsAndCommands = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            //Configuration.UseDatabaseNullSemantics = false;
            //Configuration.ValidateOnSaveEnabled = false;
        }

        public IDbSet<Curso> Cursos { get; set; }
        //public IDbSet<Materia> Materias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CursoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
