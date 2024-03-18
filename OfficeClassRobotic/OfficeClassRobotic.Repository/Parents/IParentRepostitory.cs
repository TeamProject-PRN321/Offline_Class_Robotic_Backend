﻿using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Parents
{
    public interface IParentRepostitory
    {
        public Task<ClassRoboticResponse> CreateParent(CreateParentCommand parent);
        public Task<ClassRoboticResponse> UpdateParent(UpdateParentCommand parent);
        public Task<ClassRoboticResponse> DeleteParent(DeleteParentCommand parent);
        public Task<List<ParentResponse>> GetAllParent();
        public Task<ParentResponse> GetParentById(string parentId);
        public Task<ParentResponse> GetParentByAppUserId(string appUserId);
        public Task<ParentResponse> GetParentByName(string name);

    }
}
