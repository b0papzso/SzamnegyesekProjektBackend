using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SzamnegyesekProjekt.Models;

public partial class SzamokContext : DbContext
{
    public SzamokContext()
    {
    }

    public SzamokContext(DbContextOptions<SzamokContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Szamnegyesek> Szamnegyeseks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=szamok.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Szamnegyesek>(entity =>
        {
            entity.ToTable("szamnegyesek");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Szamok).HasColumnName("szamok");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
