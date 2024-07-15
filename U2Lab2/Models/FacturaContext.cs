using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace U2Lab2.Models;

public partial class FacturaContext : DbContext
{
    public FacturaContext()
    {
    }

    public FacturaContext(DbContextOptions<FacturaContext> options)
        : base(options)
    {   
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Factura;User Id=sa;Password=Password1234;");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCli).HasName("PK__Clientes__D6961917F10A1913");

            entity.Property(e => e.IdCli).HasColumnName("id_cli");
            entity.Property(e => e.CedulaCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cedula_cli");
            entity.Property(e => e.CorreoCli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_cli");
            entity.Property(e => e.FechaNacimientoCli).HasColumnName("fechaNacimiento_cli");
            entity.Property(e => e.ImagenUrlCli)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imagenUrl_cli");
            entity.Property(e => e.NombreCli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_cli");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
