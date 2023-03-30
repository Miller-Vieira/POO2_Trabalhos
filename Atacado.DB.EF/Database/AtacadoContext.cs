using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

public partial class AtacadoContext : DbContext
{
    public AtacadoContext()
    {
    }

    public AtacadoContext(DbContextOptions<AtacadoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Subcategorium> Subcategoria { get; set; }


    public virtual DbSet<Regiao> Regioes {get; set;} = null!;

    public virtual DbSet<Estado> Estados {get; set;} = null!;

    public virtual DbSet<Cidade> Cidades {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=cgr_lab15_maq10\\sqlexpress;Initial Catalog=bdAtacado;User=usrAtacado;Password=123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Subcategorium>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Subcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subcategoria_Categoria");
        });


        modelBuilder.Entity<Regiao>();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
