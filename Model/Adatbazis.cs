using System;
using System.Collections.Generic;
using KucseraCsabaVizsgaWeb;
using Microsoft.EntityFrameworkCore;

namespace KucseraCsabaVizsgaWeb.Model;

public partial class Adatbazis : DbContext
{
    public Adatbazis()
    {
    }

    public Adatbazis(DbContextOptions<Adatbazis> options)
        : base(options)
    {
    }

    public virtual DbSet<Bejelento2> Bejelento2s { get; set; }

    public virtual DbSet<Munka> Munkas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kucsera\\source\\repos\\KucseraCsabaVizsgaWeb\\Adatbazis\\Bejelent.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bejelento2>(entity =>
        {
            entity.HasKey(e => e.BejelentoId).HasName("PK__Bejelent__2A3085B10BF7699D");

            entity.ToTable("Bejelento2");

            entity.Property(e => e.Cim)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Iranyszam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Varos)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Munka>(entity =>
        {
            entity
               // .HasNoKey()
                .ToTable("Munka");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Idotartam).HasColumnType("datetime");
            entity.Property(e => e.Munkatars).HasMaxLength(50);

            entity.HasOne(d => d.Bejelento).WithMany()
                .HasForeignKey(d => d.BejelentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bejelento2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
