using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.ConvertTer;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using OfficeClassRobotic.DataTier.ConvertTer;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassSchedule> ClassSchedule { get; set; }
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
        public DbSet<RefreshToken> RefreshToken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);

            using var hmac = new HMACSHA512();

            var passWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Password1@"));

            var passWordSalt = hmac.Key;

            #region Class
            modelBuilder.Entity<Class>(x =>
            {
                x.Property(y => y.DayStudy)
                    .HasConversion(
                        from => string.Join(";", from),
                        to => string.IsNullOrEmpty(to) ? new List<string>() : to.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList(),
                        new ValueComparer<List<string>>(
                            (c1, c2) => c1.SequenceEqual(c2),
                            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                            c => c.ToList()
                    )
                );
            });
            #endregion

            #region GiaoTrinh
            modelBuilder.Entity<GiaoTrinh>().HasData(
                new GiaoTrinh
                {
                    Id = Guid.Parse("C12EA77C-C707-44C0-B3CE-420F2FF4ECD9"),
                    GiaoTrinhName = "Toan cao cap 10",
                    Description = "",
                    FilePDF = "firebaseStorage"
                }

            );
            #endregion

            #region Subject
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = Guid.Parse("54EEBE9E-2A5B-4A82-8522-1E7CD2AA4D57"),
                    SubjectName = "Toan 10",
                    TotalSlots = 21,
                    GiaoTrinhId = Guid.Parse("C12EA77C-C707-44C0-B3CE-420F2FF4ECD9")
                }

            );
            #endregion

            #region ClassSchedular
            modelBuilder.Entity<ClassSchedule>().HasData(
                new ClassSchedule
                {
                    Id = Guid.Parse("4E1CBA33-B0CF-4274-8797-6AB39788141F"),
                    DateStudy = DateTime.Now,
                    NumberOfSudent = 40,
                    ClassId = Guid.Parse("381D2E33-67E5-4CE5-B8CC-C39BD523FE8B"),
                    TeacherId = Guid.Parse("776AFBE6-9133-4DBE-B8C0-F5A23F3FE505"),
                    ClassRoomID = Guid.Parse("D2E283A6-5BF5-4D27-A2C2-994CB6D781E9")
                }
            );
            #endregion

            #region TrungTamRobotic
            modelBuilder.Entity<TrungTamRobotic>().HasData(
                new TrungTamRobotic
                {
                    Id = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95"),
                    Name = "Trung Tâm Robotic cơ sở 3",
                    Address = "123 Nguyễn Ảnh Thủ, Hóc Môn"
                }
            );
            #endregion

            #region Some Accounts That be created by Nhan^
            modelBuilder.Entity<AppUser>().HasData(
                // student
                new AppUser
                {
                    Id = Guid.Parse("2A22D7F6-6D94-4587-84D2-921C78970A91"),
                    UserName = "nhannt",
                    FullName = "Nguyen Thanh Nhan",
                    PhoneNumber = "0912345678",
                    Email = "nguyenthanhn537@gmail.com",
                    PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("P@ssw0rd11")),
                    PassWordSalt = hmac.Key,
                    DateOfBirth = new DateOnly(1990, 1, 1),
                    Gender = "Male",
                    Address = "23 Hcm",
                    PhotoUrl = "132564487asjdhkahsdkj",
                },
                // teacher
                new AppUser
                {
                    Id = Guid.Parse("BF835A7D-D002-4C9F-8BD6-0E2D321447C4"),
                    UserName = "vinnt",
                    FullName = "Nguyen Ngoc Thai Vi",
                    PhoneNumber = "0912345678",
                    Email = "vinnt537@gmail.com",
                    PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("P@ssw0rd11")),
                    PassWordSalt = hmac.Key,
                    DateOfBirth = new DateOnly(1990, 1, 1),
                    Gender = "Male",
                    Address = "23 Hcm",
                    PhotoUrl = "132564487asjdhkahsdkj",
                },
                new AppUser
                {
                    Id = Guid.Parse("45B82E13-B1FC-425D-A2B3-8B821405BFD0"),
                    UserName = "lylynp",
                    FullName = "Nguyen Phuong LyLy",
                    PhoneNumber = "0912345678",
                    Email = "lylynp537@gmail.com",
                    PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("P@ssw0rd11")),
                    PassWordSalt = hmac.Key,
                    DateOfBirth = new DateOnly(1990, 1, 1),
                    Gender = "Female",
                    Address = "23 Hcm",
                    PhotoUrl = "132564487asjdhkahsdkj",
                }
                );
            #endregion

            #region Student
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = Guid.Parse("2B9D9ACA-27DA-415B-A468-B367613A2488"),
                    //ParentId = Guid.Parse(""),
                    AppUserId = Guid.Parse("2A22D7F6-6D94-4587-84D2-921C78970A91")
                }
            );
            #endregion

            #region Relationship
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
            #endregion

            #region Admin
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = Guid.Parse("DA053AF4-CDF1-4A6B-8506-2E3939EF6351"),
                    Address = "Long An",
                    DateOfBirth = DateOnly.MinValue,
                    Email = "vinnt060402@gmail.com",
                    FullName = "Nguyễn Ngọc Thái Vĩ",
                    PhoneNumber = "0123456789",
                    Gender = "Male",
                    PhotoUrl = "abc",
                    UserName = "vinnt060402",
                    PassWordHash = passWordHash,
                    PassWordSalt = passWordSalt,
                });
            modelBuilder.Entity<AppUserRole>().HasData(new AppUserRole
            {
                AppUserId = Guid.Parse("DA053AF4-CDF1-4A6B-8506-2E3939EF6351"),
                RoleId = Guid.Parse("891E4E1C-BED5-4992-A978-FC969FDAF128")
            });
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                AppUserId = Guid.Parse("DA053AF4-CDF1-4A6B-8506-2E3939EF6351"),
            });
            #endregion

            #region Role
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
            #endregion

            #region Student
            modelBuilder.Entity<AppUser>()
                .HasData(
                    new AppUser
                    {
                        Id = Guid.Parse("275C605E-3D04-437D-8A7D-208249412CEC"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi1@gmail.com",
                        FullName = "Vĩ 1",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi1",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("4E5E39DC-7A22-4787-9083-70335FA2489C"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi2@gmail.com",
                        FullName = "Vĩ 2",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi2",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("64863E62-104C-49EE-A57E-B066936D8E8D"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi3@gmail.com",
                        FullName = "Vĩ 3",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi3",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("AF7A0942-0459-4364-B8C8-3737A4EDFFF4"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi4@gmail.com",
                        FullName = "Vĩ 4",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi4",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("5DDD65FF-16A1-4FD1-ACBF-C913F0CCE37C"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi5@gmail.com",
                        FullName = "Vĩ 5",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi5",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("AE50067C-00BC-49E2-A20C-500696A2F954"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi6@gmail.com",
                        FullName = "Vĩ 1",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi1",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    },
                    new AppUser
                    {
                        Id = Guid.Parse("75653469-5FDD-4639-9BE7-2C8FCA8CECC5"),
                        Address = "Long An",
                        DateOfBirth = DateOnly.MinValue,
                        Email = "vi7@gmail.com",
                        FullName = "Vĩ 7",
                        PhoneNumber = "0123456789",
                        Gender = "Male",
                        PhotoUrl = "abc",
                        UserName = "vi7",
                        PassWordHash = passWordHash,
                        PassWordSalt = passWordSalt,
                    }
                );

            modelBuilder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        AppUserId = Guid.Parse("75653469-5FDD-4639-9BE7-2C8FCA8CECC5"),
                        Id = Guid.Parse("3CE37D46-18E9-492D-A28E-2665B0D95A64")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("AE50067C-00BC-49E2-A20C-500696A2F954"),
                        Id = Guid.Parse("A2CD9F87-17F7-45CC-A9DA-88502A010042")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("5DDD65FF-16A1-4FD1-ACBF-C913F0CCE37C"),
                        Id = Guid.Parse("FEC8B32D-BC9A-4FBB-94E6-5871E3EE9A63")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("5DDD65FF-16A1-4FD1-ACBF-C913F0CCE37C"),
                        Id = Guid.Parse("88DE6BCD-E510-40D8-8F29-A06009CB195C")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("64863E62-104C-49EE-A57E-B066936D8E8D"),
                        Id = Guid.Parse("07C7D0E7-273E-4819-AD69-0A875EF8F021")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("4E5E39DC-7A22-4787-9083-70335FA2489C"),
                        Id = Guid.Parse("2B295A2A-4BF5-45C1-BF87-4E04F1EFF028")
                    },
                    new Student
                    {
                        AppUserId = Guid.Parse("275C605E-3D04-437D-8A7D-208249412CEC"),
                        Id = Guid.Parse("822EB9C1-D410-4E17-9B70-BB8512112AE3")
                    }
                );
            #endregion

            #region ClassRoom
            modelBuilder.Entity<Classroom>().HasData(
                new Classroom
                {
                    Id = Guid.Parse("D2E283A6-5BF5-4D27-A2C2-994CB6D781E9"),
                    ClassRoomName = "P.403",
                    Description = "Tầng 4, phòng số 3",
                    TrungTamRoboticId = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95")
                },
                new Classroom
                {
                    Id = Guid.Parse("5F59C98D-50F9-4F5E-911E-D28648EC43B1"),
                    ClassRoomName = "P.303",
                    Description = "Tầng 3, phòng số 3",
                    TrungTamRoboticId = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95")
                },
                new Classroom
                {
                    Id = Guid.Parse("29F67CFD-BA37-4B70-852A-4AF223B7788A"),
                    ClassRoomName = "P.203",
                    Description = "Tầng 2, phòng số 3",
                    TrungTamRoboticId = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95")
                },
                new Classroom
                {
                    Id = Guid.Parse("A9770BE8-9B13-4D63-A78D-C9D2EFAA79EC"),
                    ClassRoomName = "P.103",
                    Description = "Tầng 1, phòng số 3",
                    TrungTamRoboticId = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95")
                }
            );
            #endregion

            #region Teacher
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = Guid.Parse("776AFBE6-9133-4DBE-B8C0-F5A23F3FE505"),
                    AppUserId = Guid.Parse("BF835A7D-D002-4C9F-8BD6-0E2D321447C4")
                },
                new Teacher
                {
                    Id = Guid.Parse("53525C34-3437-4B3B-946C-E9BE0A60C0C3"),
                    AppUserId = Guid.Parse("45B82E13-B1FC-425D-A2B3-8B821405BFD0")
                }

            );
            #endregion

            #region TeacherSubject
            modelBuilder.Entity<TeacherSubject>().HasData(
                new TeacherSubject
                {
                    TeacherId = Guid.Parse("776AFBE6-9133-4DBE-B8C0-F5A23F3FE505"),
                    SubjectId = Guid.Parse("54EEBE9E-2A5B-4A82-8522-1E7CD2AA4D57")
                },
                new TeacherSubject
                {
                    TeacherId = Guid.Parse("53525C34-3437-4B3B-946C-E9BE0A60C0C3"),
                    SubjectId = Guid.Parse("54EEBE9E-2A5B-4A82-8522-1E7CD2AA4D57")
                }
            );
            #endregion

            #region Class
            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = Guid.Parse("381D2E33-67E5-4CE5-B8CC-C39BD523FE8B"),
                    ClassName = "SE1603",
                    DayStudy = new List<string> { "Thứ 2", "Thứ 4" },
                    StartTime = TimeSpan.FromHours(15).Add(TimeSpan.FromMinutes(0)),
                    EndTime = TimeSpan.FromHours(18).Add(TimeSpan.FromMinutes(0)),
                    StudentId = Guid.Parse("2B9D9ACA-27DA-415B-A468-B367613A2488"),
                    SubjectId = Guid.Parse("54EEBE9E-2A5B-4A82-8522-1E7CD2AA4D57")
                }

            );
            #endregion

            #region Device
            modelBuilder.Entity<Device>().HasData(
                new Device
                {
                    Id = Guid.Parse("DFF2458C-3F40-423B-8AA9-D7588A4AE4FE"),
                    DeviceName = "Bàn học",
                    Description = "bàn 1 người ngồi",
                    PriceOfDevice = 120000,
                    StatusOfDevice = 1,
                    ClassRoomId = Guid.Parse("D2E283A6-5BF5-4D27-A2C2-994CB6D781E9")
                },
                new Device
                {
                    Id = Guid.Parse("958E60A2-FA2D-4437-B639-316A569F3AB9"),
                    DeviceName = "Ghế",
                    Description = "Ghế 1 người ngồi",
                    PriceOfDevice = 200000,
                    StatusOfDevice = 2,
                    ClassRoomId = Guid.Parse("D2E283A6-5BF5-4D27-A2C2-994CB6D781E9")
                },
                new Device
                {
                    Id = Guid.Parse("BF5B9E8E-4B5D-4FD2-8F45-B070558C64C0"),
                    DeviceName = "Quạt",
                    Description = "Quạt trần",
                    PriceOfDevice = 200000,
                    StatusOfDevice = 3,
                    ClassRoomId = Guid.Parse("D2E283A6-5BF5-4D27-A2C2-994CB6D781E9")
                }

            );
            #endregion

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
