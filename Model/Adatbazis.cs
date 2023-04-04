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

    public virtual DbSet<Hibajelento> Hibajelentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kucsera\\source\\repos\\KucseraCsabaVizsgaWeb\\adatbazis.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hibajelento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hibajele__3214EC07226C7A06");

            entity.ToTable("Hibajelento");

            entity.Property(e => e.Cim).HasMaxLength(50);
            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.Iranyszam)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Varos).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
