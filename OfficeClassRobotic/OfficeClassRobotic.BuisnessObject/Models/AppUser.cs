﻿
using OfficeClassRobotic.BuisnessObject.Models;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
        public byte[] PassWordHash { get; set; }
        public byte[] PassWordSalt { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string? PhotoUrl { get; set; }
        public AppUser() => Id = Guid.NewGuid();

        // relationship
        public virtual Admin Admin { get; set; }
        public virtual Student Student { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Staff Staff { get; set; }

        public IList<AppUserRole> AppUserRoles { get; set; }
    }
}
