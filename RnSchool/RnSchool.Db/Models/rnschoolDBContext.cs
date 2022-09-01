using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RnSchool.Db.Models
{
    public partial class rnschoolDBContext : DbContext
    {
        public rnschoolDBContext()
        {
        }

        public rnschoolDBContext(DbContextOptions<rnschoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StaffRole> StaffRole { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=COMPND-LTP-470\\MSSQLSERVER01;database=rnschoolDB;integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClassTeacher)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.ClassTeacherId)
                    .HasConstraintName("FK_Class_Staff");

                entity.HasOne(d => d.MonitorStudent)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.MonitorStudentId)
                    .HasConstraintName("FK_Class_Students");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.DateOfJoining).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_StaffRole");
            });

            modelBuilder.Entity<StaffRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.Address)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(15);

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Class");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
