using AutoMapper;
using HoneyWell.Models;
using HoneyWell.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Mapper
{
    public class PermissionsMapping:Profile
    {
        /// <summary>
        /// The permission mapping constructor
        /// </summary>
        public PermissionsMapping()
        {
            CreateMap<Roles, RolesDto>().ReverseMap();
            CreateMap<Tasks, TaskDto>().ReverseMap();
            CreateMap<Permissions, PermissionDto>().ReverseMap();
        }
    }
}
