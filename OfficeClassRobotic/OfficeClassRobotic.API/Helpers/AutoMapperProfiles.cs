using AutoMapper;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.API.DTOs;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;

namespace OfficeClassRobotic.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<RegisterDto, AppUser>();
            CreateMap<Parent, ParentResponse>();
            CreateMap<Student, StudentResponse>();
        }
    }
}
