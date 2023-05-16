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

    public virtual DbSet<tblSavedGame> tblSavedGames { get; set; }

    public virtual DbSet<tblSetting> tblSettings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Team9.Connect4.DB;Integrated Security=true");
        optionsBuilder.UseSqlServer("Server=tcp:wilkedb.database.windows.net,1433;Initial Catalog=wilkedb;Persist Security Info=False;User ID=wilkedb;Password=Test123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblPlayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblPlaye__3214EC07F5D4A4E5");

            entity.ToTable("tblPlayer");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Setting).WithMany(p => p.tblPlayers)
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblPlayer_SettingId");
        });

        modelBuilder.Entity<tblResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblResul__3214EC0706761777");

            entity.ToTable("tblResult");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Loser).WithMany(p => p.tblResultLosers)
                .HasForeignKey(d => d.LoserID)
                .HasConstraintName("fk_tblResult_LoserId");

            entity.HasOne(d => d.Winner).WithMany(p => p.tblResultWinners)
                .HasForeignKey(d => d.WinnerId)
                .HasConstraintName("fk_tblResult_WinnerId");
        });

        modelBuilder.Entity<tblSavedGame>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSaved__3214EC07F21F78FF");

            entity.ToTable("tblSavedGame");

            entity.HasIndex(e => e.GameCode, "UQ__tblSaved__18C8460CE2B4BF2E").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GameCode)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Results).WithMany(p => p.tblSavedGames)
                .HasForeignKey(d => d.ResultsId)
                .HasConstraintName("fk_tblSavedGame_ResultsId");
        });

        modelBuilder.Entity<tblSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSetti__3214EC0784F3B972");

            entity.ToTable("tblSetting");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BoardColor).HasMaxLength(6);
            entity.Property(e => e.OpponentColor).HasMaxLength(6);
            entity.Property(e => e.PlayerColor).HasMaxLength(6);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
