using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.GiaoTrinhForSubject
{
    public class GiaoTrinhForSubjectDAO
    {
        private static GiaoTrinhForSubjectDAO instance = null;
        private static ApplicationDBContext dBContext = null;

        public GiaoTrinhForSubjectDAO()
        {
            dBContext = new ApplicationDBContext();
        }

        public static GiaoTrinhForSubjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiaoTrinhForSubjectDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task CreateGiaoTrinhForSubject(GiaoTrinhDTO giaotrinh)
        {
            try {

                /*var subject = await dBContext.Subjects.Where(s => s.StudentID.Equals(giaotrinh.SubjectDTO.StudentID)).SingleOrDefaultAsync();
                if (subject != null) {
                    throw new Exception("BadRequest");
                }*/
                var subject = new Subject();
                subject.SubjectName = giaotrinh.SubjectDTO.SubjectName;
                subject.TotalSlots = giaotrinh.SubjectDTO.TotalSlots;
                subject.StudentID = giaotrinh.SubjectDTO.StudentID;
                dBContext.Subjects.Add(subject);
                await dBContext.SaveChangesAsync();

                var giaotrinhEntity = new GiaoTrinh
                {
                    GiaoTrinhName = giaotrinh.GiaoTrinhName,
                    Description = giaotrinh.Description,
                    FilePDF = giaotrinh.FilePDF,
                    SubjectID = subject.SubjectID,
                };
                dBContext.GiaoTrinhs.Add(giaotrinhEntity);

                await dBContext.SaveChangesAsync();
                
            }
            catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            
        }
    }
}
