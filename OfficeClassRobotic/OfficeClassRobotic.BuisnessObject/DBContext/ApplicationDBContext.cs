﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DataTier.ConvertTer;

namespace OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<GiaoTrinh> GiaoTrinhs { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TrungTamRobotic> TrungTamRobotics { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                     .AddJsonFile("appsettings.json", true, true)
                     .Build();
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
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

        public ApplicationDBContext()
        {
        }
    }
    
}
