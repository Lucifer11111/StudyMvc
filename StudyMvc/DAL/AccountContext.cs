using StudyMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudyMvc.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("AccountContext")
        {
        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}