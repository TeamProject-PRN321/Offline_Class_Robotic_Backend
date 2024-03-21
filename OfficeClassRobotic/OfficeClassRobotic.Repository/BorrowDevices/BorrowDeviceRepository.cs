using OfficeClassRobotic.DAO.BorrowDevices;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.BorrowDevices
{
    public class BorrowDeviceRepository : IBorrowDeviceRepository
    {
        private BorrowDeviceDAO _dao;
        public BorrowDeviceRepository()
        {
            _dao = new BorrowDeviceDAO();
        }
        public async Task<ClassRoboticResponse> TeacherBorrowDevice(BorrowDeviceDTO request)
        {
            await _dao.Instance.TeacherBorrowDevice(request);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.CreateSuccessfully
            };
        }
    }
}
