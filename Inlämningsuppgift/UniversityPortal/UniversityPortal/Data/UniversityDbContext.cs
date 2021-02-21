using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UniversityPortal.Entities;
using UniversityPortal.Models;

#nullable disable

namespace UniversityPortal.Data
{
    public partial class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
        {
        }

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<SchoolClassCourse> SchoolClassCourses { get; set; }
        public virtual DbSet<SchoolClassStudent> SchoolClassStudents { get; set; }
        public virtual DbSet<SchoolCourse> SchoolCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Micke\\Documents\\universityportal-main.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SchoolClass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClassEnd).HasColumnType("date");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ClassStart).HasColumnType("date");

                entity.Property(e => e.TeacherId).HasMaxLength(450);
            });

            modelBuilder.Entity<SchoolClassCourse>(entity =>
            {
                entity.HasKey(e => new { e.SchoolClassId, e.SchoolCourseId })
                    .HasName("PK__SchoolCl__EDA3F0A38D3CDAD4");

                entity.Property(e => e.TeacherId).HasMaxLength(450);

                entity.HasOne(d => d.SchoolClass)
                    .WithMany(p => p.SchoolClassCourses)
                    .HasForeignKey(d => d.SchoolClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolCla__Schoo__2A4B4B5E");

                entity.HasOne(d => d.SchoolCourse)
                    .WithMany(p => p.SchoolClassCourses)
                    .HasForeignKey(d => d.SchoolCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolCla__Schoo__2B3F6F97");
            });

            modelBuilder.Entity<SchoolClassStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__SchoolCl__32C52B995E4B3A93");

                entity.HasOne(d => d.SchoolClass)
                    .WithMany(p => p.SchoolClassStudents)
                    .HasForeignKey(d => d.SchoolClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolCla__Schoo__276EDEB3");
            });

            modelBuilder.Entity<SchoolCourse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
