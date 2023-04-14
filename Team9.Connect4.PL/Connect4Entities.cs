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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Team9.Connect4.DB;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblPlayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblPlaye__3214EC073012DE6C");

            entity.ToTable("tblPlayer");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Setting).WithMany(p => p.tblPlayers)
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblPlayer_SettingId");
        });

        modelBuilder.Entity<tblResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblResul__3214EC079E699DAF");

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
            entity.HasKey(e => e.Id).HasName("PK__tblSetti__3214EC07051DAEEE");

            entity.ToTable("tblSetting");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
