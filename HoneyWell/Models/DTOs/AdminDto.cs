using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Models.DTOs
{
    public class AdminDto
    {
        public List<RolesDto> Roles { get; set; }
        public List<TaskDto> Tasks { get; set; }
        public List<PermissionDto> Permissions { get; set; }
    }
}
