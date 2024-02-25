using AutoMapper;
using Azure.Core;
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
        private SubjectDAO _subjectDAO;
        private readonly IMapper _mapper;
        public SubjectRepository(IMapper mapper)
        {
            _subjectDAO = new SubjectDAO();
            _mapper = mapper;
        }
        public async Task<ClassRoboticResponse> UpdateSubject(UpdateSubjectCommand subject)
        {
            await _subjectDAO.UpdateSubject(subject);
            return new ClassRoboticResponse
            {
                Message = "Udpate Successfully"
            };
        }

        public async Task<ClassRoboticResponse> CreateSubject(CreateSubjectCommand request)
        {
            await _subjectDAO.CreateSubject(request);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<ClassRoboticResponse> DeleteSubject(DeleteSubjectCommand request)
        {
            await _subjectDAO.DeleteSubject(request);
            return new ClassRoboticResponse
            {
                Message = "Delete Successfully"
            };
        }

        public async Task<List<SubjectResponse>> GetAllSubject()
        {
            var subjects = await _subjectDAO.GetAllSubject();
            var subjectListResponse = new List<SubjectResponse>();
            foreach (var subject in subjects) {
                var subjectResponse = new SubjectResponse
                {
                    Id = subject.Id,
                    SubjectName = subject.SubjectName,
                    TotalSlots = subject.TotalSlots,
                    GiaoTrinhData = _mapper.Map<GiaoTrinhResponse>(await _subjectDAO.GetGiaoTrinhById(subject.GiaoTrinhId))
                };
                subjectListResponse.Add(subjectResponse);
            }
            return subjectListResponse;
        }

        public async Task<SubjectResponse> GetSubjectById(string subjectId)
        {
            var subject = await _subjectDAO.GetSubjectById(subjectId);
            var subjectResponse = new SubjectResponse
            {
                Id = subject.Id,
                SubjectName = subject.SubjectName,
                TotalSlots = subject.TotalSlots,
                GiaoTrinhData = _mapper.Map<GiaoTrinhResponse>(await _subjectDAO.GetGiaoTrinhById(subject.GiaoTrinhId))
            };
            return subjectResponse;
        }
    }
}
