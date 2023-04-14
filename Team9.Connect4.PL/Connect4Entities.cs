using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Team9.Connect4.PL;

public partial class Connect4Entities : DbContext
{
    public Connect4Entities()
    {
    }

    public Connect4Entities(DbContextOptions<Connect4Entities> options)
        : base(options)
    {
    }

    public virtual DbSet<tblPlayer> tblPlayers { get; set; }

    public virtual DbSet<tblResult> tblResults { get; set; }

    public virtual DbSet<tblSetting> tblSettings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=wilkedb.database.windows.net;Initial Catalog=wilkedb;User Id=wilkedb;Password=Test123!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        optionsBuilder.UseLazyLoadingProxies(true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblPlayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblPlaye__3214EC07045D7E90");

            entity.ToTable("tblPlayer");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Setting).WithMany(p => p.tblPlayers)
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblPlayer_SettingId");
        });

        modelBuilder.Entity<tblResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblResul__3214EC0757224420");

            entity.ToTable("tblResult");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Loser).WithMany(p => p.tblResultLosers)
                .HasForeignKey(d => d.LoserID)
                .HasConstraintName("fk_tblResult_LoserId");

            entity.HasOne(d => d.Winner).WithMany(p => p.tblResultWinners)
                .HasForeignKey(d => d.WinnerId)
                .HasConstraintName("fk_tblResult_WinnerId");
        });

        modelBuilder.Entity<tblSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSetti__3214EC072D78F21E");

            entity.ToTable("tblSetting");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
