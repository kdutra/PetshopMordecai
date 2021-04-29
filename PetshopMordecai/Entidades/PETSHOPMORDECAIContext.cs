using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PetshopMordecai
{
    public partial class PETSHOPMORDECAIContext : DbContext
    {
        public PETSHOPMORDECAIContext()
        {
        }

        public PETSHOPMORDECAIContext(DbContextOptions<PETSHOPMORDECAIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.ToTable("VENDA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
