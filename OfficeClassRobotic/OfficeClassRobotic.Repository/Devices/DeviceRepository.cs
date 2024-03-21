using OfficeClassRobotic.DAO.DeviceCategories;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Devices
{
    public class DeviceRepository : IDeviceRepository
    {
        private DeviceCategoryDAO _dao;

        public DeviceRepository()
        {
            _dao = new DeviceCategoryDAO();
        }

        public async Task<ClassRoboticResponse> CreateDeviceCategory(CreateDeviceCategoryDTO request)
        {
            await _dao.Instance.CreateDeviceCategory(request);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.CreateSuccessfully
            };
        }
        public async Task<List<GetDeviceCategoryDTO>> GetAllDeviceCategoryAndListDevice()
        {
            return await _dao.Instance.GetAllDeviceCategoryAndListDevice();
        }
        public async Task<GetDeviceCategoryDTO> GeDeviceCategoryAndListDeviceByDeviceCategoryId(Guid deviceCategoryId)
        {
            return await _dao.Instance.GeDeviceCategoryAndListDeviceByDeviceCategoryId(deviceCategoryId);
        }
        public async Task<ClassRoboticResponse> UpdateAndAddMoreDivices(UpdateAndAddMoreDivices request)
        {
            await _dao.Instance.UpdateAndAddMoreDivices(request);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.UpdateSuccessfully
            };
        }


    }
}
