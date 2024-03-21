using OfficeClassRobotic.DAO.BorrowDevices;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.BorrowDevices
{
    public interface IBorrowDeviceRepository
    {
        public Task<ClassRoboticResponse> TeacherBorrowDevice(BorrowDeviceDTO request);
        public Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacher();
        public Task<ClassRoboticResponse> AdminAcceptRequestOfTeacher(Guid borrowDeviceId);
        public Task<ClassRoboticResponse> AdminRejectRequestOfTeacher(Guid borrowDeviceId);
        public Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher();
        public Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(Guid appUserTeacherId);
        public Task<ClassRoboticResponse> TeacherGiveDevicesBack(Guid borrowDeviceId, Guid appUserTeacherId);

    }
}
