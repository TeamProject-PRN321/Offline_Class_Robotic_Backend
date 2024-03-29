﻿using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.Repository.Parents;

namespace OfficeClassRobotic.API.Controllers.Parents
{
    [Route("api/v1/parent")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly IParentRepostitory _parentRepostitory;
        public ParentsController(IParentRepostitory parentRepostitory)
        {
            _parentRepostitory = parentRepostitory;
        }

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateParentCommand request)
        {
            var result = _parentRepostitory.CreateParent(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateParentCommand request)
        {
            var result = _parentRepostitory.UpdateParent(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteParentCommand request)
        {
            var result = _parentRepostitory.DeleteParent(request);
            return result;
        }

        [HttpGet]
        [Route("get-all-parent")]
        public async Task<List<ParentResponse>> GetAllParent()
        {
            return await _parentRepostitory.GetAllParent();
        }

        [HttpGet]
        [Route("get-parent-by-id/{parentId}")]
        public Task<ParentResponse> GetById(Guid parentId)
        {
            var result = _parentRepostitory.GetParentById(parentId);
            return result;
        }

        [HttpGet]
        [Route("get-parent-by-appuser-id/{appUserId}")]
        public Task<ParentResponse> GetByAppUserId(Guid appUserId)
        {
            var result = _parentRepostitory.GetParentByAppUserId(appUserId);
            return result;
        }

        [HttpGet]
        [Route("get-parent-by-name/{name}")]
        public Task<List<ParentResponse>> GetByName(string name)
        {
            var result = _parentRepostitory.GetParentByName(name);
            return result;
        }
    }
}
