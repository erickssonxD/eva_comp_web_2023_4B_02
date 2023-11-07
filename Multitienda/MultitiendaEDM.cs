namespace Multitienda
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MultitiendaEDM : DbContext
    {
        public MultitiendaEDM()
            : base("name=MultitiendaEntities")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.nombre)
                .IsFixedLength();

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Productoes)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripcion)
                .IsFixedLength();
        }
    }
}
