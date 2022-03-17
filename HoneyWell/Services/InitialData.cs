using HoneyWell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Services
{
    public static class InitialData
    {
        public static void Seed(this PermissionsContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                //roles
                dbContext.Roles.Add(new Roles
                {
                    //RoleID=1,
                    RoleName="Product Administrator"
                });
                dbContext.Roles.Add(new Roles
                {
                    //RoleID = 2,
                    RoleName = "Engineer"
                });

                //tasks
                dbContext.Tasks.Add(new Tasks
                {
                    //TaskID=1,
                    Name="Task 1",
                    TaskGroup="Action"
                });
                dbContext.Tasks.Add(new Tasks
                {
                    //TaskID = 2,
                    Name = "Task 2",
                    TaskGroup = "Action"
                });
                dbContext.Tasks.Add(new Tasks
                {
                    //TaskID = 3,
                    Name = "Task 3",
                    TaskGroup = "View"
                });
                dbContext.Tasks.Add(new Tasks
                {
                   // TaskID = 4,
                    Name = "Task 4",
                    TaskGroup = "View"
                });

                //permissions
                dbContext.Permissions.Add(new Permissions
                {
                  //  ID=1,
                   RoleID=1,
                   TaskID = "{ 1, 2, 3, 4 }"
                });
                dbContext.Permissions.Add(new Permissions
                {
                   // ID=2,
                    RoleID = 2,
                    TaskID = "{ 2, 3}"
                });

                dbContext.SaveChanges();
            }
        }
    }
}
