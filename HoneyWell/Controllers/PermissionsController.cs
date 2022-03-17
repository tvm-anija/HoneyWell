using AutoMapper;
using HoneyWell.Models;
using HoneyWell.Models.DTOs;
using HoneyWell.Services.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Controllers
{
    [Route("api/permissions")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly IRolesRepository _irolesRepository;
        private readonly IMapper _mapper;

        public PermissionsController(IRolesRepository irolesRepository, IMapper mapper)
        {
            _irolesRepository = irolesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var adminObj = new AdminDto();

            //roles
            var rolesList = _irolesRepository.GetRoles();
            var rolesDto = new List<RolesDto>();
            foreach (var obj in rolesList)
            {
                rolesDto.Add(_mapper.Map<RolesDto>(obj));
            }
            adminObj.Roles = rolesDto;

            //tasks
            var tasksList = _irolesRepository.GetTasks();
            var tasksDto = new List<TaskDto>();
            foreach (var obj in tasksList)
            {
                tasksDto.Add(_mapper.Map<TaskDto>(obj));
            }
            adminObj.Tasks = tasksDto;

            //permissions
            var permisssionsList = _irolesRepository.GetPermissions();
            var permissionDto = new List<PermissionDto>();
            foreach (var obj in permisssionsList)
            {
                permissionDto.Add(_mapper.Map<PermissionDto>(obj));
            }
            adminObj.Permissions = permissionDto;

            return Ok(adminObj);
        }

        [HttpPost]
        public IActionResult UpdatePermission([FromBody] List<PermissionDto> permissionDtos)
        {
            if (permissionDtos == null)
            {
                return BadRequest(ModelState);
            }
            List<Permissions> permissions = new List<Permissions>();
            foreach(PermissionDto permissionDto in permissionDtos)
            {
                var permissionsObj = _mapper.Map<Permissions>(permissionDto);
                permissions.Add(permissionsObj);
            }
            
            if (!_irolesRepository.UpdatePermissions(permissions))
            {
                ModelState.AddModelError("", $"Something went wrong when updating the record");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}
