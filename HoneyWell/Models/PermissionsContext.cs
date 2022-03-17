using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyWell.Models
{
    public class PermissionsContext :DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public PermissionsContext(DbContextOptions options):base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Permissions>().HasNoKey();
        //}
    }
}
