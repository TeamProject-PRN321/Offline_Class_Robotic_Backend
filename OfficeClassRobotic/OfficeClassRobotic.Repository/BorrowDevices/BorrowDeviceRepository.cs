using Azure.Core;
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

        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher()
        {
            return await _dao.Instance.ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher();
        }

        public async Task<ClassRoboticResponse> AdminAcceptRequestOfTeacher(Guid borrowDeviceId)
        {
            await _dao.Instance.AdminAcceptRequestOfTeacher(borrowDeviceId);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.AdminAccessSuccessfully
            };
        }

        public async Task<ClassRoboticResponse> AdminRejectRequestOfTeacher(Guid borrowDeviceId)
        {
            await _dao.Instance.AdminRejectRequestOfTeacher(borrowDeviceId);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.AdminRejectSuccessfully
            };
        }

        public async Task<ClassRoboticResponse> TeacherBorrowDevice(BorrowDeviceDTO request)
        {
            await _dao.Instance.TeacherBorrowDevice(request);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.CreateSuccessfully
            };
        }

        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacher()
        {
            return await _dao.Instance.ViewAllRequestBorrowDeviceOfTeacherInHistory();
        }
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(Guid appUserTeacherId)
        {
            return await _dao.Instance.ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(appUserTeacherId);
        }

        public async Task<ClassRoboticResponse> TeacherGiveDevicesBack(Guid borrowDeviceId, Guid appUserTeacherId)
        {
            await _dao.Instance.TeacherGiveDevicesBack(borrowDeviceId,appUserTeacherId);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.TeacherGiveBackSuccefully
            };
        }
    }
}
