using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ValidationPractice.EF.Tables;

namespace ValidationPractice.EF;

public partial class ValidationPracticeContext : DbContext
{
    public ValidationPracticeContext()
    {
    }

    public ValidationPracticeContext(DbContextOptions<ValidationPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<UserDatum> UserData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DbConn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("student_id");
            entity.Property(e => e.Cgpa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cgpa");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Roll).HasColumnName("roll");
        });

        modelBuilder.Entity<UserDatum>(entity =>
        {
            entity.ToTable("user_data");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
