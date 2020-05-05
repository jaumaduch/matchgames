using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XGame_Domain.Entities;

namespace XGame_Infra.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XGameConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Jogador> Jogadores { get; set; }

        public IDbSet<Plataformas> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength (100));

            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
