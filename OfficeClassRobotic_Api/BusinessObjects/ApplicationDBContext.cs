using BusinessObjects.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>().HasKey(p => p.ParnetID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.ParentID);

            modelBuilder.Entity<Parent>().HasData(
                new Parent { ParnetID = 1, Name = "Parent 1", Address = "Address 1", Phone = "123456789", Birthday = new System.DateOnly(1990, 1, 1) },
                new Parent { ParnetID = 2, Name = "Parent 2", Address = "Address 2", Phone = "987654321", Birthday = new System.DateOnly(1985, 5, 10) }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 1, Name = "Student 1", Address = "Student Address 1", Birthday = new System.DateOnly(2000, 3, 15), ParentID = 1 },
                new Student { StudentID = 2, Name = "Student 2", Address = "Student Address 2", Birthday = new System.DateOnly(1998, 7, 20), ParentID = 1 }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverterExtensions>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
