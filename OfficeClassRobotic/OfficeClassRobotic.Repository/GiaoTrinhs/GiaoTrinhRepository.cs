using AutoMapper;
using Azure;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;

namespace OfficeClassRobotic.Repository.GiaoTrinhs
{
    public class GiaoTrinhRepository : IGiaoTrinhRepository
    {
        private GiaoTrinhDAO _giaoTrinhDAO;
        private readonly IMapper _mapper;
        public GiaoTrinhRepository(IMapper mapper)
        {
            _giaoTrinhDAO = new GiaoTrinhDAO();
            _mapper = mapper;
        }
        public async Task<ClassRoboticResponse> CreateGiaoTrinh(CreateGiaoTrinhCommand giaoTrinh)
        {
            await _giaoTrinhDAO.CreateGiaoTrinh(giaoTrinh);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<ClassRoboticResponse> DeleteGiaoTrinh(DeleteGiaoTrinhCommand giaoTrinh)
        {
            await _giaoTrinhDAO.DeleteGiaoTrinh(giaoTrinh);
            return new ClassRoboticResponse
            {
                Message = "Delete Successfully"
            };
        }

        public async Task<List<GiaoTrinhResponse>> GetAllGiaoTrinh()
        {
            var response = await _giaoTrinhDAO.GetAllGiaoTrinh();
            var data = _mapper.Map<List<GiaoTrinhResponse>>(response);
            return data;
        }

        public async Task<GiaoTrinhPDFResponse> GetGiaoTrinhById(string giaoTrinhId)
        {
            var response = await _giaoTrinhDAO.GetGiaoTrinhById(giaoTrinhId);
            var data = _mapper.Map<GiaoTrinhPDFResponse>(response);
            return data;
        }

        public async Task<ClassRoboticResponse> UpdateGiaoTrinh(UpdateGiaoTrinhCommand giaoTrinh)
        {
            await _giaoTrinhDAO.UpdateGiaoTrinh(giaoTrinh);
            return new ClassRoboticResponse
            {
                Message = "Update Successfully"
            };
        }

        public async Task<List<GiaoTrinhPDFResponse>> GetPdfFilesFromDatabase(string subjectId)
        {
            var response = await _giaoTrinhDAO.GetGiaoTrinhPDFBySubjectId(subjectId);
            var data = _mapper.Map<List<GiaoTrinhPDFResponse>>(response);
            return data;
        }
    }
}
