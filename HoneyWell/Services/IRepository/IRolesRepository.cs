using HoneyWell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Services.IRepository
{
    public interface IRolesRepository
    {
        /// <summary>
        /// The list of all roles
        /// </summary>
        /// <returns>list of roles from db</returns>
        ICollection<Roles> GetRoles();

        /// <summary>
        /// The list of all tasks
        /// </summary>
        /// <returns>list of tasks from db</returns>
        ICollection<Tasks> GetTasks();

        /// <summary>
        /// The list of all permissions
        /// </summary>
        /// <returns>list of permissions from db</returns>
        ICollection<Permissions> GetPermissions();

        /// Method to update the permissions
        /// </summary>
        /// <param name="Permission">The permission object</param>
        /// <returns>bool</returns>
        bool UpdatePermissions(List<Permissions> permissions);
    }
}
