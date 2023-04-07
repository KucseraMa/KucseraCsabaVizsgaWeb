using System;
using System.Collections.Generic;
using KucseraCsabaVizsgaWeb;
using Microsoft.EntityFrameworkCore;

namespace KucseraCsabaVizsgaWeb.Model;

/*public partial class Bejelento : DbContext
{
    public Bejelento()
    {
    }

    public Bejelento(DbContextOptions<Bejelento> options)
        : base(options)
    {
    }

    public virtual DbSet<Bejelento> Bejelentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kucsera\\source\\repos\\KucseraCsabaVizsgaWeb\\Adatbazis\\Bejelent.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bejelento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bejelent__3214EC076BA1F10F");

            entity.ToTable("Bejelento");

            entity.Property(e => e.Id).ValueGeneratedNever();
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
*/