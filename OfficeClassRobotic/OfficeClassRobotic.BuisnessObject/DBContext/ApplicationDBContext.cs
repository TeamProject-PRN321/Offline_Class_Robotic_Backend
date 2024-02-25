using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.ConvertTer;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using OfficeClassRobotic.DataTier.ConvertTer;

namespace OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<GiaoTrinh> GiaoTrinhs { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TrungTamRobotic> TrungTamRobotics { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<SubjectGradingWeight> SubjectGradingWeights { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);

            modelBuilder.Entity<AppUserRole>(entity =>
            {
                entity.HasKey(ss => new { ss.RoleId, ss.AppUserId });

                entity.HasOne(ss => ss.Role)
                .WithMany(ss => ss.AppUserRoles)
                .HasForeignKey(ss => ss.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(ss => ss.AppUser)
                .WithMany(ss => ss.AppUserRoles)
                .HasForeignKey(ss => ss.AppUserId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.HasKey(tS => new { tS.SubjectId, tS.TeacherId });

                entity.HasOne(tS => tS.Teacher)
                .WithMany(s => s.TeacherSubjects)
                .HasForeignKey(tS => tS.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(tS => tS.Subject)
                .WithMany(s => s.TeacherSubjects)
                .HasForeignKey(tS => tS.SubjectId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = Guid.Parse("B308C9A8-9A44-4662-B010-E4688FB8E019"),
                    RoleName = "Student"
                },
                new Role
                {
                    Id = Guid.Parse("1C477667-FBC0-4C85-9D2F-1F5A6DA3EDAC"),
                    RoleName = "Parent"
                },
                new Role
                {
                    Id = Guid.Parse("DC1C58F1-326B-43C0-A750-263BCEEE32BE"),
                    RoleName = "Staff"
                },
                new Role
                {
                    Id = Guid.Parse("891E4E1C-BED5-4992-A978-FC969FDAF128"),
                    RoleName = "Admin"
                },
                new Role
                {
                    Id = Guid.Parse("433CA17D-2BB8-4A98-91E6-5703365CB2FD"),
                    RoleName = "Teacher"
                },
                new Role
                {
                    Id = Guid.Parse("A53D0CCA-65D1-4B81-AFE2-E735FACD6C38"),
                    RoleName = "TrungTamRobotic"
                });
                
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                     .AddJsonFile("appsettings.json", true, true)
                     .Build();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseAuditableEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created = DateTime.Now;
                    entry.Entity.CreateBy = CustomSessionManager.GetString("username");
                }
                if (entry.State == EntityState.Modified || entry.State == EntityState.Deleted)
                {
                    entry.Entity.LastModified = DateTime.Now;
                    entry.Entity.LastModifiedBy = CustomSessionManager.GetString("username");
                }

            }
            return base.SaveChangesAsync(cancellationToken);
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
