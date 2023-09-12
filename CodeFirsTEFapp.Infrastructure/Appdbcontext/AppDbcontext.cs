using CodeFirsTEFapp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Infrastructure.Appdbcontext
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext()
        {
            
        }
        public AppDbcontext(DbContextOptions<AppDbcontext>options):base(options)
        {
            
        }
       public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherSubject> TeachersSubject { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=::1;Port=5432;Database=Hello;user id=postgres;password=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.Id)
                .HasName("PK_Teacher");

            modelBuilder.Entity<Subject>()
                .HasKey(s => s.Id)
                .HasName("PK_Subject");

            modelBuilder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.SubjectID, ts.TeacherID })
                .HasName("PK_TeacherSubject");

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Subject)
                .WithMany(s => s.TeacherSubjects)
                .HasForeignKey(ts => ts.SubjectID)
                .IsRequired()
                .HasConstraintName("FK_TeacherSubject_Subject");
            modelBuilder.Entity<TeacherSubject>().HasOne(ts => ts.Teacher).WithMany(t => t.TeacherSubjects).HasForeignKey(t => t.TeacherID).IsRequired().HasConstraintName("FK_TeacherSubject_Teacher");
            modelBuilder.Entity<TeacherSubject>()
                  .HasOne(ts => ts.Subject)
                  .WithMany(s => s.TeacherSubjects)
                  .HasForeignKey(ts => ts.SubjectID)
                  .IsRequired()
                  .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherSubjects)
                .HasForeignKey(ts => ts.TeacherID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade); 


        }


    }
}
