using OfficeClassRobotic.DAO.DeviceCategories;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Devices
{
    public interface IDeviceRepository
    {
        public Task<ClassRoboticResponse> CreateDeviceCategory(CreateDeviceCategoryDTO request);
        public Task<List<GetDeviceCategoryDTO>> GetAllDeviceCategoryAndListDevice();
        public Task<GetDeviceCategoryDTO> GeDeviceCategoryAndListDeviceByDeviceCategoryId(Guid deviceCategoryId);
        public Task<ClassRoboticResponse> UpdateAndAddMoreDivices(UpdateAndAddMoreDivices request);

    }
}
