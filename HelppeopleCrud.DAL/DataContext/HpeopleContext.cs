using System;
using System.Collections.Generic;
using HelppeopleCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace HelppeopleCrud.DAL.DataContext;

public partial class HpeopleContext : DbContext
{
    public HpeopleContext()
    {
    }

    public HpeopleContext(DbContextOptions<HpeopleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudadano> Ciudadanos { get; set; }

    public virtual DbSet<Vacante> Vacantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudadano>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CIUDADAN__3214EC270C327FFE");

            entity.ToTable("CIUDADANOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Aspiracion).HasColumnName("ASPIRACION");
            entity.Property(e => e.Email)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.NumeroDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOC");
            entity.Property(e => e.Profesion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PROFESION");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Vacante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VACANTES__3214EC27B124DD90");

            entity.ToTable("VACANTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cargo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CARGO");
            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Empresa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMPRESA");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.IdCiudadano).HasColumnName("ID_CIUDADANO");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");

            entity.HasOne(d => d.IdCiudadanoNavigation).WithMany(p => p.Vacantes)
                .HasForeignKey(d => d.IdCiudadano)
                .HasConstraintName("FK__VACANTES__ID_CIU__37A5467C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
