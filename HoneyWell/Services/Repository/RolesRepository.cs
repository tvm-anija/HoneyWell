using HoneyWell.Models;
using HoneyWell.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Services.Repository
{
    public class RolesRepository: IRolesRepository
    {
        private readonly PermissionsContext _db;

        public RolesRepository(PermissionsContext db)
        {
            _db = db;
        }

        /// <summary>
        /// The list of all roles
        /// </summary>
        /// <returns>list of roles from db</returns>
        public ICollection<Roles> GetRoles()
        {
            return _db.Roles.OrderBy(a => a.RoleID).ToList();
        }

        /// <summary>
        /// The list of all tasks
        /// </summary>
        /// <returns>list of tasks from db</returns>
        public ICollection<Tasks> GetTasks()
        {
            return _db.Tasks.OrderBy(a => a.TaskID).ToList();
        }

        /// <summary>
        /// The list of all permissions
        /// </summary>
        /// <returns>list of permissions from db</returns>
        public ICollection<Permissions> GetPermissions()
        {
            return _db.Permissions.OrderBy(a => a.RoleID).ToList();
        }

        /// Method to update the permissions
        /// </summary>
        /// <param name="Permission">The permission object</param>
        /// <returns>bool</returns>
        public bool UpdatePermissions(List<Permissions> permissions)
        {
            foreach(Permissions permission in permissions)
            {
                Permissions p = GetPermissions().Where(x => x.RoleID == permission.RoleID).FirstOrDefault();
                p.TaskID = permission.TaskID;
                _db.Permissions.Update(p);
            }

            return Save();
        }

        /// <summary>
        /// The Save method
        /// </summary>
        /// <returns>bool</returns>
        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
