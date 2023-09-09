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
        public DbSet<Teacher>Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherSubject>TeacherSubjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=::1;Port=5432;Database=Hello;user id=postgres;password=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.SubjectID, ts.TeacherID });
        }


    }
}
