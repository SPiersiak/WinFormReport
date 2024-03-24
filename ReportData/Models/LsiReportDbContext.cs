using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReportData.Models;

public partial class LsiReportDbContext : DbContext
{
    public LsiReportDbContext()
    {
    }

    public LsiReportDbContext(DbContextOptions<LsiReportDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Premise> Premises { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Premise>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PremisesName).HasMaxLength(100);
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ReportName).HasMaxLength(100);

            entity.HasOne(d => d.Premises).WithMany(p => p.Reports).HasForeignKey(d => d.PremisesId);

            entity.HasOne(d => d.User).WithMany(p => p.Reports).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
