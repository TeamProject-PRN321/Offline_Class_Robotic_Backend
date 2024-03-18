using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.GiaoTrinhs
{
    public class GiaoTrinhDAO
    {
        private static GiaoTrinhDAO instance;
        private static ApplicationDBContext _dbContext;

        public GiaoTrinhDAO()
        {
            _dbContext = new ApplicationDBContext();
        }

        public static GiaoTrinhDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new GiaoTrinhDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task<List<GiaoTrinh>> GetAllGiaoTrinh()
        {
            try {
                var giaoTrinhList = await _dbContext.GiaoTrinhs.Where(g => !g.IsDeleted).ToListAsync();
                return giaoTrinhList;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task CreateGiaoTrinh(CreateGiaoTrinhCommand request)
        {
            try {
                foreach(var pdf in request.ListFilePDFs)
                {
                    var giaoTrinh = new GiaoTrinh
                    {
                        GiaoTrinhName = request.GiaoTrinhName,
                        Description = request.Description,
                        FilePDFName = pdf.FilePDFName,
                        FilePDF = pdf.FilePDF,
                        SubjectId = Guid.Parse(request.SubjectId),
                    };
                    _dbContext.Add(giaoTrinh);
                }
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task UpdateGiaoTrinh(UpdateGiaoTrinhCommand request)
        {
            try {
                var giaoTrinhExist = await _dbContext.GiaoTrinhs
                    .Where(g => g.Id == Guid.Parse(request.GiaoTrinhId) && !g.IsDeleted)
                    .SingleOrDefaultAsync();
                if (giaoTrinhExist == null) {
                    throw new NotFoundException("Does not existed giaoTrinhId");
                }
                giaoTrinhExist.GiaoTrinhName = request.GiaoTrinhName;
                giaoTrinhExist.Description = request.Description;
                //giaoTrinhExist.FilePDF = request.FilePDF;
                giaoTrinhExist.LastModified = DateTime.Now;

                _dbContext.Update(giaoTrinhExist);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task DeleteGiaoTrinh(DeleteGiaoTrinhCommand request)
        {
            try {
                var giaoTrinhExist = await _dbContext.GiaoTrinhs
                    .Where(g => g.Id == Guid.Parse(request.GiaoTrinhId) && !g.IsDeleted)
                    .SingleOrDefaultAsync();
                if (giaoTrinhExist == null) {
                    throw new NotFoundException("Does not existed giaoTrinhId");
                }
                giaoTrinhExist.IsDeleted = true;
                _dbContext.Update(giaoTrinhExist);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<GiaoTrinh> GetGiaoTrinhById(string giaoTrinhId)
        {
            try {
                var giaoTrinhExist = await _dbContext.GiaoTrinhs
                    .Where(g => g.Id == Guid.Parse(giaoTrinhId) && !g.IsDeleted)
                    .SingleOrDefaultAsync();
                if (giaoTrinhExist == null) {
                    throw new NotFoundException("Does not existed giaoTrinhId");
                }
                return giaoTrinhExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<List<GiaoTrinh>> GetGiaoTrinhPDFBySubjectId(string subjectId)
        {
            try
            {
                var giaoTrinhExist = await _dbContext.GiaoTrinhs
                    .Where(g => g.SubjectId == Guid.Parse(subjectId) && !g.IsDeleted)
                    .ToListAsync();
                
                return giaoTrinhExist;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
