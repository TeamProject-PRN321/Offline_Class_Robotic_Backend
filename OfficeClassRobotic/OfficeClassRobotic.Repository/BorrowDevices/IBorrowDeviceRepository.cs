using OfficeClassRobotic.DAO.BorrowDevices;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.BorrowDevices
{
    public interface IBorrowDeviceRepository
    {
        public Task<ClassRoboticResponse> TeacherBorrowDevice(BorrowDeviceDTO request);
    }
}
