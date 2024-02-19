using AutoMapper;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.DAO.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public class SubjectRepository : ISubjectRepository
    {
        private SubjectDAO _giaoTrinhDAO;
        private readonly IMapper _mapper;
        public SubjectRepository(IMapper mapper)
        {
            _giaoTrinhDAO = new SubjectDAO();
            _mapper = mapper;
        }

        public async Task<ClassRoboticResponse> CreateSubjectForListStudentWithGiaoTrinh(SubjectDTO subject)
        {
            await _giaoTrinhDAO.CreateSubjectForListStudentWithGiaoTrinh(subject);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<ClassRoboticResponse> UpdateSubjectWithListStudent(UpdateSubjectDTO subject)
        {
            await _giaoTrinhDAO.UpdateSubjectWithListStudent(subject);
            return new ClassRoboticResponse
            {
                Message = "Udpate Successfully"
            };
        }

        public async Task<ClassRoboticResponse> CreateSubject(SubjectData request)
        {
            await _giaoTrinhDAO.CreateSubject(request);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
