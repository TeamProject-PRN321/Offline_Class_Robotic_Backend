using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.DeviceCategories;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.Devices;

namespace OfficeClassRobotic.API.Controllers.Devices
{
    [Route("api/v1/device")]
    [ApiController]
    public class DeviceCategoryController : ControllerBase
    {
        private IDeviceRepository _repo;

        public DeviceCategoryController(IDeviceRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public async Task<ClassRoboticResponse> CreateDeviceCategory(CreateDeviceCategoryDTO request)
        {
            return await _repo.CreateDeviceCategory(request);
        }
        [HttpPut]
        public async Task<ClassRoboticResponse> UpdateAndAddMoreDivices(UpdateAndAddMoreDivices request)
        {
            return await _repo.UpdateAndAddMoreDivices(request);
        }
        [HttpGet]
        public async Task<List<GetDeviceCategoryDTO>> GetAllDeviceCategoryAndListDevice()
        {
            return await _repo.GetAllDeviceCategoryAndListDevice();
        }
        [HttpGet]
        [Route("{deviceCategoryId}")]
        public async Task<GetDeviceCategoryDTO> GeDeviceCategoryAndListDeviceByDeviceCategoryId(Guid deviceCategoryId)
        {
            return await _repo.GeDeviceCategoryAndListDeviceByDeviceCategoryId(deviceCategoryId);
        }
    }
}
