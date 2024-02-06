using AutoMapper;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhForSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public class GiaoTrinhForSubjectRepository : IGiaoTrinhForSubjectRepository
    {
        private GiaoTrinhForSubjectDAO _giaoTrinhDAO;
        private readonly IMapper _mapper;
        public GiaoTrinhForSubjectRepository(IMapper mapper)
        {
            _giaoTrinhDAO = new GiaoTrinhForSubjectDAO();
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
    }
}
